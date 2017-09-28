using System.Collections.Generic;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

using WalletTracker.Domain.Currency;

namespace WalletTracker.Infrastructure.Web
{
    public class CoinMarketCapRepository : ICurrencyValueInfoRepository
    {
        private readonly IWebClient webClient;

        public CoinMarketCapRepository(IWebClient webClient)
        {
            this.webClient = webClient;
        }

        public async Task<CurrencyValueInfo> GetCurrencyValueInfo(Currency currency)
        {
            var url = $"https://api.coinmarketcap.com/v1/ticker/{currency.Name.ToLowerInvariant()}/?convert=EUR";

            var result = await this.webClient.GetJArrayAsync(url);

            return CreateCurrencyValueInfo(result, currency);
        }

        private static CurrencyValueInfo CreateCurrencyValueInfo(JToken data, Currency currency)
        {
            var currencyValueInfo = new CurrencyValueInfo(currency, new List<CurrencyValuePair>
            {
                new CurrencyValuePair(Currency.Euro, data[0].Value<decimal>("price_eur")),
                new CurrencyValuePair(Currency.Dollar, data[0].Value<decimal>("price_usd"))
            });

            return currencyValueInfo;
        }
    }
}
