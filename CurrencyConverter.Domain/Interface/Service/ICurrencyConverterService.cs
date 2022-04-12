using CurrencyConverter.Domain.Entity;

namespace CurrencyConverter.Domain.Interface.Service
{
    public interface ICurrencyConverterService
    {
        Task<Currencies> GetCurrencies();
    }
}
