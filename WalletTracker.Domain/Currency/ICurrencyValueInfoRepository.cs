using System.Threading.Tasks;

namespace WalletTracker.Domain.Currency
{
    public interface ICurrencyValueInfoRepository
    {
        Task<CurrencyValueInfo> GetCurrencyValueInfo(Currency currency);
    }
}
