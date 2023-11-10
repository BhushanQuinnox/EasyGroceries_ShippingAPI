using AutoFixture;
using EasyGroceries.Shipping.Application.DTOs;
using EasyGroceries.Shipping.Application.Services;

namespace EasyGroceries.Shipping.Application.Tests;

public class ShippingSlipProcessorServiceTests
{
    [Fact]
    public async void GenerateShippingSlip_Should_CreateShippingSlipTextFile()
    {
        // Arrange
        Fixture fixture = new Fixture();
        ShippingInfoDto shippingInfoDto = fixture.Create<ShippingInfoDto>();

        string fileName = $"Slip_{shippingInfoDto.UserId}.txt";
        string filePath = string.Concat(@"D:\Bhushan\ShippingSlip\", fileName);

        // Act
        ShippingSlipProcessorService shippingSlipProcessorService = new ShippingSlipProcessorService();
        await shippingSlipProcessorService.GenerateShippingSlip(shippingInfoDto);
        var isFileExists = File.Exists(filePath);

        // Assert
        Assert.True(isFileExists);
    }
}