using WalletTracker.Domain.Currency;

namespace WalletTracker.Domain.Wallet
{
    public class WalletAddress
    {
        public WalletAddress(string address, CurrencyType baseType)
        {
            this.Address = address;
            this.BaseType = baseType;
        }

        public string Address { get; private set; }

        public CurrencyType BaseType { get; private set; }
    }
}
