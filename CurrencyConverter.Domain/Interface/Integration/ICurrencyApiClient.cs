using CurrencyConverter.Domain.Entity;

namespace CurrencyConverter.Domain.Interface.Integration
{
    public interface ICurrencyApiClient
    {
        Task<Dictionary<string, decimal>> ConvertCurrencies(string coinIn, string coinOut);
        Task<Currencies> GetCurrencies();
    }
}
