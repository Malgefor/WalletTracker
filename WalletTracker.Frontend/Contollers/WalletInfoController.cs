using System.Threading.Tasks;
using System.Web.Mvc;

using WalletTracker.Domain.Currency;
using WalletTracker.Domain.Wallet;
using WalletTracker.ViewModels;

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

        [Route("overview"), HttpGet]
        public ActionResult Overview()
        {
            return View("EnterAddress", new WalletInfoViewModel());
        }

        [Route("overview"), HttpPost]
        public async Task<ActionResult> Overview(WalletInfoViewModel viewModel)
        {
            var walletInfo = await this.walletInfoRepository.GetWalletInfo(new WalletAddress(viewModel.WalletAddress, CurrencyType.ParseFromSymbol(viewModel.CurrencyType)));
            
            return View("ViewWalletInfo", walletInfo);
        }
    }
}
