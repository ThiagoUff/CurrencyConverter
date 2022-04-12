using CurrencyConverter.Domain.Entity;

namespace CurrencyConverter.Domain.Interface.Service
{
    public interface ICurrencyConverterService
    {
        Task<Dictionary<string, decimal>> ConvertCurrencies(string coinIn, string coinOut);
        Task<Currencies> GetCurrencies();
        Task<decimal> GetValueConversor(decimal value, string coinIn, string coinOut);
    }
}
