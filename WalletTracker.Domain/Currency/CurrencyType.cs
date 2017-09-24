namespace WalletTracker.Domain.Currency
{
    public class CurrencyType
    {
        public static readonly CurrencyType Ethereum = new CurrencyType("Ethereum");

        private CurrencyType(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}