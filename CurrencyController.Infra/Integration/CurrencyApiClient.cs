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

        public async Task<Dictionary<string, decimal>> ConvertCurrencies(string coinIn, string coinOut)
        {
            return await base.Get<Dictionary<string,decimal>>($"convert?q={coinIn}_{coinOut}&compact=ultra&apiKey={ConfigConsts.API_KEY}");
        }
    }
}
