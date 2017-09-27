using System.Collections.Generic;

using WalletTracker.Domain.Token;

namespace WalletTracker.Domain.Wallet
{
    public class WalletInfo
    {
        public WalletInfo(WalletAddress address, List<TokenInfo> tokens)
        {
            this.Address = address;
            this.Tokens = tokens;
        }

        public WalletAddress Address { get; private set; }

        public List<TokenInfo> Tokens { get; private set; }
    }
}
