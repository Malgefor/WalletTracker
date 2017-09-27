namespace WalletTracker.Domain.Currency
{
    public class CurrencyType
    {
        public static readonly CurrencyType Crypto = new CurrencyType("Crypto");
        public static readonly CurrencyType Fiat = new CurrencyType("Fiat");

        private CurrencyType(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }
}
