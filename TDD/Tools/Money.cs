namespace TDD.Tools
{
    public class Money : Expression
    {
        protected int amount;
        protected string currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);

        }

        public Expression Plus(Money addend)
        {
            return new Money(amount + addend.amount, currency);
        }

        public string Currency()
        {
            return currency;
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
            return amount == money.amount
                && Currency().Equals(money.Currency());
        }














        public override string ToString()
        {
            return amount + " " + currency;
        }

        public override int GetHashCode()
        {
            throw new System.NotImplementedException();
        }
    }
}
