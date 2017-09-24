using System.Threading.Tasks;

namespace WalletTracker.Domain.Wallet
{
    public interface IWalletInfoRepository
    {
        Task<WalletInfo> GetWalletInfo(WalletAddress address);
    }
}