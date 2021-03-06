using CurrencyConverter.Domain.Entity;
using CurrencyConverter.Domain.Interface.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyConverterService _currencyConverterService;
        
        public CurrencyController(ICurrencyConverterService currencyConverterService)
        {
            _currencyConverterService = currencyConverterService;
        }

        [HttpGet("currencies")]
        public async Task<ActionResult<Currencies>> GetCurrencies()
        {
           return Ok( await _currencyConverterService.GetCurrencies());
        }

        [HttpGet("convert/{coinIn}-{coinOut}")]
        public async Task<ActionResult<Dictionary<string, decimal>>> ConvertCurrencies(string coinIn, string coinOut)
        {
            return Ok(await _currencyConverterService.ConvertCurrencies(coinIn, coinOut));
        }

        [HttpGet("quotation/{value}-{coinIn}-{coinOut}")]
        public async Task<ActionResult<decimal>> GetValueConversor(decimal value, string coinIn, string coinOut)
        {
            return Ok(await _currencyConverterService.GetValueConversor(value, coinIn, coinOut));
        }
    }
}
