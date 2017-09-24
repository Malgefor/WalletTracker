using System.Configuration;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

using WalletTracker.Domain.Wallet;

namespace WalletTracker.Infrastructure.Web.WalletAddressInfoProviders
{
    public class EthplorerClient : IEthplorerClient, IWalletInfoRepository
    {
        private readonly IWebClient webClient;

        public EthplorerClient(IWebClient webClient)
        {
            this.webClient = webClient;
        }

        public async Task<WalletInfo> GetWalletInfo(WalletAddress address)
        {
            var apiKey = "freekey";

            var url = $"https://api.ethplorer.io/getTokenInfo/{address.Address}?apikey={apiKey}";

            var result = await this.webClient.GetAsync(url);

            return CreateWalletInfo(result, address);
        }

        private static WalletInfo CreateWalletInfo(JToken result, WalletAddress address)
        {
            return new WalletInfo(address, result.Value<double>("result"));
        }
    }
}