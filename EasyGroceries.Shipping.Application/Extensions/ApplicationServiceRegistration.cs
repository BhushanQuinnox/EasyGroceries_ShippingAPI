using EasyGroceries.Shipping.Application.Contracts.Messaging;
using EasyGroceries.Shipping.Application.Contracts.Services;
using EasyGroceries.Shipping.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EasyGroceries.Shipping.Application.Extensions
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<IAzureServiceBusConsumer, AzureServiceBusConsumer>();
            services.AddSingleton<IShippingSlipProcessorService, ShippingSlipProcessorService>();
            return services;
        }
    }
}
