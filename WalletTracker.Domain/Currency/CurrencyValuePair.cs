namespace WalletTracker.Domain.Currency
{
    public class CurrencyValuePair
    {
        public CurrencyValuePair(Currency currency, decimal currentValue)
        {
            this.Currency = currency;
            this.CurrentValue = currentValue;
        }

        public Currency Currency { get; private set; }

        public decimal CurrentValue { get; private set; }
    }
}
