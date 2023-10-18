using Azure.Messaging.ServiceBus;
using EasyGroceries.Shipping.Application.Contracts.Messaging;
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
        private ServiceBusProcessor _shippingProcessor;

        public AzureServiceBusConsumer(IConfiguration configuration)
        {
            _configuration = configuration;
            var client = new ServiceBusClient(_configuration.GetConnectionString("ServiceBusConnectionString"));
            var shippingSlipQueueName = _configuration.GetSection("TopicAndQueueNames:GenerateShippingSlipQueue");
            _shippingProcessor = client.CreateProcessor(shippingSlipQueueName.Value);
        }

        public async Task Start()
        {
            _shippingProcessor.ProcessMessageAsync += OnShippingRequestReceived;
            await _shippingProcessor.StartProcessingAsync();
        }

        public async Task Stop()
        {
            await _shippingProcessor.StopProcessingAsync();
        }

        private async Task OnShippingRequestReceived(ProcessMessageEventArgs arg)
        {
            var message = arg.Message;
            var body = Encoding.UTF8.GetString(message.Body);

            OrderHeaderDto objMessage = JsonConvert.DeserializeObject<OrderHeaderDto>(body);
            try
            {

                await arg.CompleteMessageAsync(arg.Message);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
