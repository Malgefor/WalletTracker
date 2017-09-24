namespace WalletTracker.Domain.Wallet
{
    public class WalletInfo
    {
        public WalletInfo(WalletAddress address, double tokenBalance)
        {
            this.Address = address;
            this.TokenBalance = tokenBalance;
        }

        public WalletAddress Address { get; set; }

        public double TokenBalance { get; set; }
    }
}