using System.Collections.Generic;

namespace WalletTracker.Domain.Currency
{
    public class CurrencyValueInfo
    {
        public CurrencyValueInfo(Currency currency, List<CurrencyValuePair> currencyValuePairs)
        {
            this.Currency = currency;
            this.CurrencyValuePairs = currencyValuePairs;
        }

        public Currency Currency { get; private set; }

        public List<CurrencyValuePair> CurrencyValuePairs { get; private set; }
    }
}
