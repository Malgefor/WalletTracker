using System.Threading.Tasks;

namespace WalletTracker.Domain.Wallet
{
    public interface IWalletInfoService
    {
        Task<WalletInfo> GetWalletInfo(WalletAddress address);
    }
}