using Microsoft.AspNetCore.Mvc;

namespace CurrencyExchangeService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyConvertController : ControllerBase
    {
       
        private readonly ILogger<CurrencyConvertController> _logger;

        public CurrencyConvertController(ILogger<CurrencyConvertController> logger)
        {
            _logger = logger;
        }

        
    }
}