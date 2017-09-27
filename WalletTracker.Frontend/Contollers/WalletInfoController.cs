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
        private readonly IWalletInfoService walletInfoRepository;
        private readonly ICurrencyValueInfoRepository currencyValueInfoRepository;

        public WalletInfoController(IWalletInfoService walletInfoRepository, ICurrencyValueInfoRepository currencyValueInfoRepository)
        {
            this.walletInfoRepository = walletInfoRepository;
            this.currencyValueInfoRepository = currencyValueInfoRepository;
        }

        [Route("overview"), HttpGet]
        public ActionResult Overview()
        {
            return View("EnterAddress", new WalletInfoViewModel());
        }

        [Route("overview"), HttpPost]
        public async Task<ActionResult> Overview(WalletInfoViewModel viewModel)
        {
            var walletInfo = await this.walletInfoRepository.GetWalletInfo(new WalletAddress(viewModel.WalletAddress, Currency.ParseFromSymbol(viewModel.CurrencyType)));
            
            return View("ViewWalletInfo", walletInfo);
        }
    }
}
