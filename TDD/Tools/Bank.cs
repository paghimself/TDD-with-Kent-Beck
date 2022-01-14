using System.Collections;

namespace TDD.Tools
{
    public class Bank
    {
        private Hashtable rates = new();

        public Money Reduce(IExpression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }

        public int Rate(string from, string to)
        {
            if (from.Equals(to)) { return 1; }

            var rate = (int) rates[new Pair(from, to)];
            return rate;
        }
    }
}
