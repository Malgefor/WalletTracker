﻿using System.Threading.Tasks;

using WalletTracker.Domain.Currency;

namespace WalletTracker.Domain.Wallet
{
    public interface IWalletInfoRepository
    {
        Task<WalletInfo> GetWalletInfo(WalletAddress address);

        CurrencyType BaseCurrencyType { get; }
    }
}
