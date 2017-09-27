using WalletTracker.Domain.Currency;

namespace WalletTracker.Domain.Token
{
    public class TokenInfo
    {
        public TokenInfo(decimal balance, CurrencyType currencyType)
        {
            this.Balance = balance;
            this.CurrencyType = currencyType;
        }

        public decimal Balance { get; private set; }

        public CurrencyType CurrencyType { get; private set; }
    }
}
