using System.Collections.Generic;

using WalletTracker.Domain.Currency;
using WalletTracker.Domain.Wallet;

namespace WalletTracker.ViewModels
{
    public class WalletInfoOverviewViewModel
    {
        public WalletInfoOverviewViewModel(WalletInfo walletInfo, List<CurrencyValueInfo> currencyValueInfo)
        {
            this.WalletInfo = walletInfo;
            this.CurrencyValueInfo = currencyValueInfo;
        }

        public WalletInfo WalletInfo { get; private set; }

        public List<CurrencyValueInfo> CurrencyValueInfo { get; private set; }
    }
}
