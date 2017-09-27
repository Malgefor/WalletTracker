using System.Collections.Generic;
using System.Linq;

namespace WalletTracker.Domain.Currency
{
    public class CurrencyType
    {
        public static readonly CurrencyType Ethereum = new CurrencyType("Ethereum", "ETH", null);
        public static readonly CurrencyType Golem = new CurrencyType("Golem", "GNT", Ethereum);
        public static readonly CurrencyType FunFair = new CurrencyType("FunFair", "FUN", Ethereum);

        private CurrencyType(string name, string symbol, CurrencyType baseCurrencyType)
        {
            this.Name = name;
            this.Symbol = symbol;
            this.BaseCurrencyType = baseCurrencyType;
        }

        public string Name { get; private set; }

        public string Symbol { get; private set; }

        public CurrencyType BaseCurrencyType { get; private set; }

        public static CurrencyType ParseFromSymbol(string symbol)
        {
            return All().FirstOrDefault(c => c.Symbol.Equals(symbol));
        }

        public static IEnumerable<CurrencyType> All()
        {
            yield return Ethereum;
            yield return Golem;
            yield return FunFair;
        }
    }
}
