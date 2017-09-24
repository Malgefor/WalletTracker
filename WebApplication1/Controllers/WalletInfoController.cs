using System.Threading.Tasks;
using System.Web.Mvc;

using WalletTracker.Domain.Currency;
using WalletTracker.Domain.Wallet;

namespace WebApplication1.Controllers
{
    [RoutePrefix("wallet-info")]
    public class WalletInfoController : Controller
    {
        private readonly IWalletInfoRepository walletInfoRepository;

        public WalletInfoController(IWalletInfoRepository walletInfoRepository)
        {
            this.walletInfoRepository = walletInfoRepository;
        }

        [Route("view"), HttpGet]
        public async Task<ActionResult> ViewWalletAddressInfo()
        {
            var walletInfo = await this.walletInfoRepository.GetWalletInfo(new WalletAddress("0x97FcCA516fE0781922c21475eA9459da25bA70F3", CurrencyType.Ethereum));

            return View(walletInfo);
        }
    }
}