using AutoFixture;
using Azure.Messaging.ServiceBus;
using EasyGroceries.Shipping.Application.Contracts.Services;
using EasyGroceries.Shipping.Application.DTOs;
using EasyGroceries.Shipping.Application.Services;
using Microsoft.Extensions.Configuration;
using Moq;

namespace EasyGroceries.Shipping.Application.Tests;

public class AzureServiceBusConsumerTests
{
    private readonly Mock<IConfiguration> _configurationMock;
    // private readonly Mock<ServiceBusProcessor> _serviceBusProcessorMock;
    private readonly Mock<IShippingSlipProcessorService> _shippingSlipProcessorMock;

    public AzureServiceBusConsumerTests()
    {
        _configurationMock = new Mock<IConfiguration>();
        // _serviceBusProcessorMock = new Mock<ServiceBusProcessor>();
        _shippingSlipProcessorMock = new Mock<IShippingSlipProcessorService>();
    }

    [Fact]
    public void Start_Should_RaiseOnShippingRequestReceivedEventMethod()
    {
        // Arrange


        // Act


        // Assert
    }
}