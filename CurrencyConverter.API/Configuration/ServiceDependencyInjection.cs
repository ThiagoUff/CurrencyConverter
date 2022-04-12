using CurrencyConverter.Domain.Interface.Integration;
using CurrencyConverter.Domain.Interface.Service;
using CurrencyConverter.Infra.Integration;
using CurrencyConverter.Service.Service;

namespace CurrencyConverter.API.Configuration
{
    static class ServiceDependencyInjection
    {
        public static IServiceCollection AddDependencies (this IServiceCollection services)
        {
            //Integration
            services.AddScoped<ICurrencyApiClient, CurrencyApiClient>();

            //Services
            services.AddScoped<ICurrencyConverterService, CurrencyConverterService>();

            return services;
        }
    }
}
