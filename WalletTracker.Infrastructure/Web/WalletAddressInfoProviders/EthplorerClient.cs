using System;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

using WalletTracker.Domain.Currency;
using WalletTracker.Domain.Token;
using WalletTracker.Domain.Wallet;

namespace WalletTracker.Infrastructure.Web.WalletAddressInfoProviders
{
    public class EthplorerClient : IWalletInfoRepository
    {
        private readonly IWebClient webClient;

        public EthplorerClient(IWebClient webClient)
        {
            this.webClient = webClient;
        }

        public async Task<WalletInfo> GetWalletInfo(WalletAddress address)
        {
            var apiKey = "freekey";

            var url = $"https://api.ethplorer.io/getAddressInfo/{address.Address}?apiKey={apiKey}";

            var result = await this.webClient.GetJObjectAsync(url);

            return CreateWalletInfo(result, address);
        }

        public Currency BaseCurrency => Currency.Ethereum;

        private static WalletInfo CreateWalletInfo(JToken result, WalletAddress address)
        {
            var tokens = result
                .SelectToken("tokens")
                .Select(t => new TokenInfo(GetBalance(t), Currency.ParseFromSymbol(t.SelectToken("tokenInfo").Value<string>("symbol"))))
                .ToList();

            tokens.Add(new TokenInfo(result.SelectToken("ETH").Value<decimal>("balance"), Currency.Ethereum));

            return new WalletInfo(
                address,
                tokens);
        }

        private static decimal GetBalance(JToken t)
        {
            var decimals = (Math.Pow(10, t.SelectToken("tokenInfo").Value<int>("decimals")));
            var balance = t.Value<decimal>("balance");

            return balance / Convert.ToDecimal(decimals);
        }
    }
}
