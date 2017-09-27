using System;
using System.Configuration;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

using WalletTracker.Domain.Currency;
using WalletTracker.Domain.Wallet;

namespace WalletTracker.Infrastructure.Web.WalletAddressInfoProviders
{
    [Obsolete]
    public class EtherscanClient //: IWalletInfoRepository
    {
        private readonly IWebClient webClient;

        public EtherscanClient(IWebClient webClient)
        {
            this.webClient = webClient;
        }

        public async Task<WalletInfo> GetWalletInfo(WalletAddress address)
        {
            //var apiKey = ConfigurationManager.AppSettings["etherscan:apikey"];

            //var url = $"https://api.etherscan.io/api?module=account&action=balance&address={address.Address}&tag=latest&apikey={apiKey}";

            //var result = await this.webClient.GetAsync(url);

            //return CreateWalletInfo(result, address);

            throw new NotImplementedException();
        }

        public CurrencyType CurrencyType => CurrencyType.Ethereum;

        //private static WalletInfo CreateWalletInfo(JToken result, WalletAddress address)
        //{
        //    return new WalletInfo(address, result.Value<double>("result"));
        //}
    }
}
