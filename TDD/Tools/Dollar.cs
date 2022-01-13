namespace TDD.Tools
{
    public class Dollar
    {
        public int Amount { get; set; }

        public Dollar(int amount)
        {
            this.Amount = amount;
        }

        public void Times(int multiplier)
        {
            Amount *= multiplier;
        }


    }
}
