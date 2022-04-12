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
        public async Task<ActionResult<Currencies>> Get()
        {
           return Ok( await _currencyConverterService.GetCurrencies());
        }
    }
}
