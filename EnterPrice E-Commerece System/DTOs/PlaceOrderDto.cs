using EnterPrice_E_Commerece_System.Entites.Sales___Orders_Module;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterPrice_E_Commerece_System.DTOs
{
    public class PlaceOrderDto
    {
        public int UserId { set; get; }
        public int ShiipingAddressId { set; get; }
        public PaymentMethod paymentMethod { get; set; }
        public IEnumerable<OrderItemDto> orderItemDtos { get; set; } 
    }
}
