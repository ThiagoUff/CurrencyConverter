using CurrencyConverter.Domain;
using CurrencyConverter.Domain.Entity;
using CurrencyConverter.Domain.Interface.Integration;

namespace CurrencyConverter.Infra.Integration
{
    public class CurrencyApiClient : BaseClient, ICurrencyApiClient
    {
        public CurrencyApiClient(IHttpClientFactory clientFactory): base("CurrencyApiClient", clientFactory) { }

        public async Task<Currencies> GetCurrencies()
        {
            return await base.Get<Currencies>($"currencies?apiKey={ConfigConsts.API_KEY}");
        }
    }
}
