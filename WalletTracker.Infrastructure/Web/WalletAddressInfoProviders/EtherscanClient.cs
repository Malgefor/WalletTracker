using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

using WalletTracker.Domain.Wallet;

namespace WalletTracker.Infrastructure.Web.WalletAddressInfoProviders
{
    public class EtherscanClient : IEtherScanClient, IWalletInfoRepository
    {
        private readonly IWebClient webClient;

        public EtherscanClient(IWebClient webClient)
        {
            this.webClient = webClient;
        }

        public async Task<WalletInfo> GetWalletInfo(WalletAddress address)
        {
            var apiKey = "AQMWSXP1F7UV69PI3VT4BEGDM8XS54ARNF";
            var result =
                await
                    this.webClient.GetAsync(
                        $"https://api.etherscan.io/api?module=account&action=balance&address={address.Address}&tag=latest&apikey={apiKey}");

            return CreateWalletInfo(result, address);
        }

        private static WalletInfo CreateWalletInfo(JObject result, WalletAddress address)
        {
            return new WalletInfo(address, result.Value<double>("result"));
        }
    }
}
