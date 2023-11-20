using EasyGroceries.Shipping.Application.Contracts.Services;
using EasyGroceries.Shipping.Application.DTOs;

namespace EasyGroceries.Shipping.Application.Services
{
    public class ShippingSlipProcessorService : IShippingSlipProcessorService
    {
        public async Task GenerateShippingSlip(ShippingInfoDto shippingInfoDto)
        {
            string shippingSlipContent = $"UserId {shippingInfoDto.UserId} has pushases total {shippingInfoDto.ProductDetails.Count()} products of cost {shippingInfoDto.OrderTotal}";
            string fileName = $"Slip_{shippingInfoDto.UserId}.txt";
            string filePath = string.Concat(@"D:\Bhushan\ShippingSlip\", fileName);
            await File.WriteAllTextAsync(filePath, shippingSlipContent);
        }
    }
}