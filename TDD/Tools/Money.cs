namespace TDD.Tools
{
    public class Money
    {
        protected int amount;


        public override bool Equals(object obj)
        {
            if (this.GetType() == obj.GetType())
            {
                Money money = (Money)obj;
                return amount == money.amount;
            }

            return false;
        }
    }
}
