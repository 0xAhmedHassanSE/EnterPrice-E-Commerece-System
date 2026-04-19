using EnterPrice_E_Commerece_System.CRUD;
using EnterPrice_E_Commerece_System.DTOs;
using EnterPrice_E_Commerece_System.Entites;
using EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module;
using Microsoft.EntityFrameworkCore;

namespace EnterPrice_E_Commerece_System.Services
{
    public class OrderService : IOrderService
    {

        private readonly IUnitOfWork unitOfWork;

        public OrderService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        public async Task<bool> PlaceOrderAsync(PlaceOrderDto placeOrderDto)
        {
            const int maxRetryNumber = 3;

           for(int attempt = 1; attempt < maxRetryNumber; attempt++) { 
                try
                {
                    return await ExecuteCheckoutProcessAsync(placeOrderDto);
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    unitOfWork.ClearTracking();
                    if (attempt == maxRetryNumber)
                    {
                        Console.WriteLine(ex.Message);
                        throw new DbUpdateConcurrencyException(ex.Message);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw new Exception(e.Message);
                }
            }
            return false;
        }
        private async Task<bool> ExecuteCheckoutProcessAsync(PlaceOrderDto placeOrderDto)
        {

            var productVarientIds = placeOrderDto.orderItemDtos.Select(orderItem => orderItem.ProductVarientId).Distinct().ToList();
            var ProductVarients = unitOfWork.ProductVariants.GetAll(pv => productVarientIds.Contains(pv.ProductVariantID)).ToDictionary(pv => pv.ProductVariantID);
            var productIds = ProductVarients.Values.Select(pv => pv.ProductID).Distinct().ToList();
            var products = unitOfWork.Products.GetAll(p => productIds.Contains(p.ProductID)).ToDictionary(p => p.ProductID);
            var inventories = unitOfWork.Inventories.GetAll(i => productVarientIds.Contains(i.ProductVariantId));
            decimal totalAmount = 0;
            var order = new Order
            {
                ShippingAddressId = placeOrderDto.ShiipingAddressId,
                UserId = placeOrderDto.UserId,
                OrderDate = DateTime.UtcNow,
                Status = OrderStatus.Pending
            };
            var payment = new Payment()
            {
                Order = order,
                PaymentMethod = placeOrderDto.paymentMethod,
                PaymentDate = DateTime.UtcNow,
                IsSuccessful = true
            };
            List<OrderItem> orderItemList = new();

            foreach (var orderItemDto in placeOrderDto.orderItemDtos)
            {
                var productVarient = ProductVarients[orderItemDto.ProductVarientId];
                var product = products[productVarient.ProductID];
                var inventory = inventories.Where(i => i.ProductVariantId == productVarient?.ProductVariantID).
                    FirstOrDefault(i => i.QuantityAvailable >= orderItemDto.Quantity);
                if (inventory is not null && product is not null)
                {
                    inventory.QuantityAvailable -= orderItemDto.Quantity;
                    unitOfWork.Inventories.Update(inventory);
                    totalAmount += orderItemDto.Quantity * product.BasePrice;

                    var orderItem = new OrderItem()
                    {
                        Order = order,
                        ProductVariantId = orderItemDto.ProductVarientId,
                        Quantity = orderItemDto.Quantity,
                        UnitPrice = product.BasePrice
                    };
                    orderItemList.Add(orderItem);
                }
                else
                    throw new Exception($"Available Quantity is less than demand Quantity in {productVarient?.ProductVariantID} ");
            }
            order.TotalAmount = totalAmount;
            payment.Amount = totalAmount;

            await unitOfWork.Orders.AddAsync(order);
            await unitOfWork.Payments.AddAsync(payment);
            await unitOfWork.OrderItems.AddRangeAsync(orderItemList);
            return await unitOfWork.CompleteAsync() > 0;
        }
    }
}
