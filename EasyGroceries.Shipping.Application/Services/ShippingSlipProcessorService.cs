using EasyGroceries.Shipping.Application.Contracts.Services;
using EasyGroceries.Shipping.Application.DTOs;

namespace EasyGroceries.Shipping.Application.Services
{
    public class ShippingSlipProcessorService : IShippingSlipProcessorService
    {

        public async Task GenerateShippingSlip(ShippingInfoDto shippingInfoDto)
        {
            // Generate shiiping slip here
        }
    }
}