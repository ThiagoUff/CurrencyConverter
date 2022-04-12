using CurrencyConverter.Domain.Entity;
using CurrencyConverter.Domain.Interface.Integration;
using CurrencyConverter.Domain.Interface.Service;

namespace CurrencyConverter.Service.Service
{
    public class CurrencyConverterService : ICurrencyConverterService
    {
        private readonly ICurrencyApiClient _currencyApiClient;
        public CurrencyConverterService(ICurrencyApiClient currencyApiClient)
        {
            _currencyApiClient = currencyApiClient;
        }

        public async Task<Currencies> GetCurrencies()
        {
            return await _currencyApiClient.GetCurrencies();
        }

        public async Task<Dictionary<string, decimal>> ConvertCurrencies(string coinIn, string coinOut)
        {
            return await _currencyApiClient.ConvertCurrencies(coinIn, coinOut);
        }

        public async Task<decimal> GetValueConversor(decimal value, string coinIn, string coinOut)
        {
            return (await _currencyApiClient.ConvertCurrencies(coinIn, coinOut)).ElementAt(0).Value * value;
        } 
    }
}
