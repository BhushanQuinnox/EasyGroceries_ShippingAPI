using EasyGroceries.Shipping.Application.DTOs;

namespace EasyGroceries.Shipping.Application.Contracts.Services
{
    public interface IShippingSlipProcessorService
    {
        Task GenerateShippingSlip(OrderHeaderDto headerDto);
    }
}