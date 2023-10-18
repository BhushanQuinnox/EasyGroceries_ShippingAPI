using EasyGroceries.Shipping.Application.Contracts.Messaging;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGroceries.Shipping.Application.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        private static IAzureServiceBusConsumer _serviceBusConsumer { get; set; }

        public static IApplicationBuilder UseAzureServiceBusConsumer(this IApplicationBuilder app)
        {
            _serviceBusConsumer = app.ApplicationServices.GetService<IAzureServiceBusConsumer>();
            var hostApplicationLife = app.ApplicationServices.GetService<IHostApplicationLifetime>();

            hostApplicationLife.ApplicationStarted.Register(OnStart);
            hostApplicationLife.ApplicationStopping.Register(OnStop);

            return app;
        }

        private static void OnStop()
        {
            _serviceBusConsumer.Stop();
        }

        private static void OnStart()
        {
            _serviceBusConsumer.Start();
        }
    }
}
