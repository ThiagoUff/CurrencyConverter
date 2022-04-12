using CurrencyConverter.Domain.Entity;

namespace CurrencyConverter.Domain.Interface.Integration
{
    public interface ICurrencyApiClient
    {
        Task<Currencies> GetCurrencies();
    }
}
