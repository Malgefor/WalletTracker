using WalletTracker.Domain.Currency;

namespace WalletTracker.Domain.Token
{
    public class TokenInfo
    {
        public TokenInfo(decimal balance, Currency.Currency currency)
        {
            this.Balance = balance;
            this.Currency = currency;
        }

        public decimal Balance { get; private set; }

        public Currency.Currency Currency { get; private set; }
    }
}
