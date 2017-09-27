using WalletTracker.Domain.Currency;

namespace WalletTracker.Domain.Wallet
{
    public class WalletAddress
    {
        public WalletAddress(string address, Currency.Currency @base)
        {
            this.Address = address;
            this.Base = @base;
        }

        public string Address { get; private set; }

        public Currency.Currency Base { get; private set; }
    }
}
