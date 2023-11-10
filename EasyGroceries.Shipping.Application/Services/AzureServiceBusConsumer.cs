using Azure.Messaging.ServiceBus;
using EasyGroceries.Shipping.Application.Contracts.Messaging;
using EasyGroceries.Shipping.Application.Contracts.Services;
using EasyGroceries.Shipping.Application.DTOs;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGroceries.Shipping.Application.Services
{
    public class AzureServiceBusConsumer : IAzureServiceBusConsumer
    {
        private readonly IConfiguration _configuration;
        private ServiceBusProcessor _serviceBusProcessor;
        private readonly IShippingSlipProcessorService _shippingSlipProcessorService;

        public AzureServiceBusConsumer(IConfiguration configuration, IShippingSlipProcessorService shippingSlipProcessorService)
        {
            _configuration = configuration;
            _shippingSlipProcessorService = shippingSlipProcessorService;
            var client = new ServiceBusClient(_configuration.GetConnectionString("ServiceBusConnectionString"));
            var shippingSlipQueueName = _configuration.GetSection("TopicAndQueueNames:GenerateShippingSlipQueue");
            _serviceBusProcessor = client.CreateProcessor(shippingSlipQueueName.Value);
        }

        public async Task Start()
        {
            _serviceBusProcessor.ProcessMessageAsync += OnShippingRequestReceived;
            await _serviceBusProcessor.StartProcessingAsync();
        }

        public async Task Stop()
        {
            await _serviceBusProcessor.StopProcessingAsync();
        }

        private async Task OnShippingRequestReceived(ProcessMessageEventArgs arg)
        {
            var message = arg.Message;
            var body = Encoding.UTF8.GetString(message.Body);
            ShippingInfoDto shippingInfo = JsonConvert.DeserializeObject<ShippingInfoDto>(body);
            await _shippingSlipProcessorService.GenerateShippingSlip(shippingInfo);
            await arg.CompleteMessageAsync(arg.Message);
        }
    }
}
