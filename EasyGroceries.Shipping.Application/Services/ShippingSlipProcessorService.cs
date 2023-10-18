using EasyGroceries.Shipping.Application.Contracts.Services;
using EasyGroceries.Shipping.Application.DTOs;

namespace EasyGroceries.Shipping.Application.Services
{
    public class ShippingSlipProcessorService : IShippingSlipProcessorService
    {
        public Task GenerateShippingSlip(OrderHeaderDto headerDto)
        {
            // TBD: Generate shipping slip by extracting data from headerdto
            return null;
        }
    }
}