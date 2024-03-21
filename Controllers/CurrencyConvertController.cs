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

        [HttpGet("ConvertCurrency")]
        public IActionResult ConvertCurrency(string source, string target, decimal amount)
        {
            var result = _currencyExchangeService.ConvertCurrency(source, target, amount);
            if (result == "Invalid Currency.")
            {
                return BadRequest(new { msg = "Invalid Currency." });
            }
            return Ok(new { msg = "success", amount = result });
        }

    }
}