namespace TDD.Tools
{
    public abstract class Money
    {
        protected int amount;
        protected string currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public abstract Money Times(int amount);


        public string Currency()
        {
            return currency;
        }

        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Franc Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public override bool Equals(object obj)
        {
            if (this.GetType() == obj.GetType())
            {
                Money money = (Money)obj;
                return amount == money.amount;
            }

            return false;
        }











        public override int GetHashCode()
        {
            throw new System.NotImplementedException();
        }
    }
}
