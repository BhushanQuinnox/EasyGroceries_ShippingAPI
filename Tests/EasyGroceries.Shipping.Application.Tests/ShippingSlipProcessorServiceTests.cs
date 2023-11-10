using AutoFixture;
using EasyGroceries.Shipping.Application.DTOs;
using EasyGroceries.Shipping.Application.Services;

namespace EasyGroceries.Shipping.Application.Tests;

public class ShippingSlipProcessorServiceTests
{
    [Fact]
    public async void GenerateShippingSlip_Should_CreateShippingSlipTextFile()
    {
        Fixture fixture = new Fixture();
        ShippingInfoDto shippingInfoDto = fixture.Create<ShippingInfoDto>();
        ShippingSlipProcessorService shippingSlipProcessorService = new ShippingSlipProcessorService();
        await shippingSlipProcessorService.GenerateShippingSlip(shippingInfoDto);
    }
}