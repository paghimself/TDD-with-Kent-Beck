namespace TDD.Tools
{
    public class Money : IExpression
    {
        public int Amount { get; private set; }
        public string Currency { get; private set; }

        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }


        public Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);

        }

        public IExpression Plus(Money addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(string to)
        {
            return this;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return Amount == money.Amount
                && Currency.Equals(money.Currency);
        }














        public override string ToString()
        {
            return Amount + " " + Currency;
        }

        public override int GetHashCode()
        {
            throw new System.NotImplementedException();
        }
    }
}
