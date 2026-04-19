

using EnterPrice_E_Commerece_System.DTOs;

namespace EnterPrice_E_Commerece_System.Services
{
    public interface IOrderService
    {
        Task<bool> PlaceOrderAsync(PlaceOrderDto placeOrderDto);
    }
}
