using CurrencyExchangeServiceAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyExchangeServiceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyConvertController : ControllerBase
    {
        private readonly CurrencyExchangeService _currencyExchangeService;

        public CurrencyConvertController(CurrencyExchangeService currencyExchangeService)
        {
            _currencyExchangeService = currencyExchangeService;
        }

    }
}