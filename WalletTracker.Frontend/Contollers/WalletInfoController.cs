using System.Threading.Tasks;
using System.Web.Mvc;

using WalletTracker.Domain.Currency;
using WalletTracker.Domain.Wallet;

namespace WalletTracker.Contollers
{
    [RoutePrefix("wallet-info")]
    public class WalletInfoController : Controller
    {
        private readonly IWalletInfoRepository walletInfoRepository;

        public WalletInfoController(IWalletInfoRepository walletInfoRepository)
        {
            this.walletInfoRepository = walletInfoRepository;
        }

        [Route("view-wallet-info"), HttpGet]
        public async Task<ActionResult> ViewWalletInfo()
        {
            var walletInfo = await this.walletInfoRepository.GetWalletInfo(new WalletAddress("0x97FcCA516fE0781922c21475eA9459da25bA70F3", CurrencyType.Ethereum));

            return View(walletInfo);
        }

        [Route("view-token-info"), HttpGet]
        public async Task<ActionResult> ViewTokenInfo()
        {
            var walletInfo = await this.walletInfoRepository.GetWalletInfo(new WalletAddress("0x97FcCA516fE0781922c21475eA9459da25bA70F3", CurrencyType.Ethereum));

            return View(walletInfo);
        }
    }
}