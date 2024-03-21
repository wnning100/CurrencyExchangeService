namespace CurrencyExchangeServiceAPI.Service
{
    public class CurrencyExchangeService
    {
        private readonly Dictionary<string, Dictionary<string, decimal>> _exchangeRate;
        public CurrencyExchangeService(Dictionary<string, Dictionary<string, decimal>> exchangeRate)
        {
            _exchangeRate = exchangeRate ?? throw new ArgumentNullException(nameof(exchangeRate));
        }

    }
}
