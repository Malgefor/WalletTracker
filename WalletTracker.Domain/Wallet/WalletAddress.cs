using WalletTracker.Domain.Currency;

namespace WalletTracker.Domain.Wallet
{
    public class WalletAddress
    {
        public WalletAddress(string address, CurrencyType type)
        {
            this.Address = address;
            this.Type = type;
        }

        public string Address { get; set; }

        public CurrencyType Type { get; set; }
    }
}