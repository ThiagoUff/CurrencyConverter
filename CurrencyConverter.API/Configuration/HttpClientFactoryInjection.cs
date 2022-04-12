namespace CurrencyConverter.API.Configuration
{
    static class HttpClientFactoryInjection
    {
        public static IServiceCollection AddHttpClients(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient("CurrencyApiClient", builder =>
            {
                builder.Timeout = TimeSpan.FromSeconds(30);
                builder.BaseAddress = new Uri(configuration["WebApiUrl:CurrencyConverterApiUrl"]);
            });

            return services;
        }
    }
}
