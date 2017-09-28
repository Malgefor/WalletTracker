using System.Collections.Generic;
using System.Linq;

namespace WalletTracker.Domain.Currency
{
    public class Currency
    {
        //Crypto
        public static readonly Currency Bitcoin = new Currency("Bitcoin", "BTC", null, CurrencyType.Crypto);
        public static readonly Currency Ethereum = new Currency("Ethereum", "ETH", null, CurrencyType.Crypto);
        public static readonly Currency Golem = new Currency("Golem-Network-Tokens", "GNT", Ethereum, CurrencyType.Crypto);
        public static readonly Currency FunFair = new Currency("FunFair", "FUN", Ethereum, CurrencyType.Crypto);
        public static readonly Currency Eos = new Currency("EOS", "EOS", Ethereum, CurrencyType.Crypto);

        //Fiat
        public static readonly Currency Euro = new Currency("Euro", "EUR", null, CurrencyType.Fiat);
        public static readonly Currency Dollar = new Currency("Dollar", "USD", null, CurrencyType.Fiat);

        private Currency(string name, string symbol, Currency baseCurrency, CurrencyType currencyType)
        {
            this.Name = name;
            this.Symbol = symbol;
            this.BaseCurrency = baseCurrency;
            this.CurrencyType = currencyType;
        }

        public string Name { get; private set; }

        public string Symbol { get; private set; }

        public Currency BaseCurrency { get; private set; }

        public CurrencyType CurrencyType { get; private set; }

        public static Currency ParseFromSymbol(string symbol)
        {
            return All().FirstOrDefault(c => c.Symbol.Equals(symbol));
        }

        public static IEnumerable<Currency> All()
        {
            yield return Bitcoin;
            yield return Ethereum;
            yield return Golem;
            yield return FunFair;
            yield return Eos;
        }
    }
}
