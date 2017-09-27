using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WalletTracker.Domain.Wallet
{
    public class WalletInfoService : IWalletInfoService
    {
        private readonly IReadOnlyList<IWalletInfoRepository> walletInfoRepositories;

        public WalletInfoService(IEnumerable<IWalletInfoRepository> walletInfoRepositories)
        {
            this.walletInfoRepositories = walletInfoRepositories.ToList();
        }

        public async Task<WalletInfo> GetWalletInfo(WalletAddress address)
        {
            var selectedRepository = this.walletInfoRepositories.FirstOrDefault(w => w.BaseCurrency.Equals(address.Base));

            if (selectedRepository == null)
            {
                throw new Exception("Currency type does not have a repository!");
            }

            return await selectedRepository.GetWalletInfo(address);
        }
    }
}
