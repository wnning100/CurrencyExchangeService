namespace CurrencyExchangeServiceAPI.Service
{
    public class CurrencyExchangeService
    {
        private readonly Dictionary<string, Dictionary<string, decimal>> _exchangeRate;
        public CurrencyExchangeService(Dictionary<string, Dictionary<string, decimal>> exchangeRate)
        {
            _exchangeRate = exchangeRate ?? throw new ArgumentNullException(nameof(exchangeRate));
        }

        /// <summary>
        /// 匯率轉換
        /// </summary>
        /// <param name="source">輸入幣別</param>
        /// <param name="target">輸出幣別</param>
        /// <param name="amount">匯率</param>
        /// <returns></returns>
        public string ConvertCurrency(string source, string target, decimal amount)
        {
            if (_exchangeRate.ContainsKey(source) && _exchangeRate[source].ContainsKey(target))
            {
                var targetAmount = amount * _exchangeRate[source][target];
                // 四捨五入取小數點到第二位
                targetAmount = Math.Round(targetAmount, 2);
                // 將結果轉換為字串，並加入千分位
                var result = string.Format("{0:N}", targetAmount);
                return result;
            }

            return "Invalid Currency.";
        }
    }
}
