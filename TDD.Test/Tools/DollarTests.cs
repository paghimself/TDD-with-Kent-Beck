using Xunit;
using TDD.Tools;

namespace TDD.Test.Tools
{
    public class DollarTests
    {
        // Currency
        [Fact]
        public void TestCurrency()
        {
            Assert.Equal("USD", Money.Dollar(1).Currency());
            Assert.Equal("CHF", Money.Franc(1).Currency());
        }


        // Multiplication
        [Fact]
        public void TestDollarMultiplication()
        {
            var five = Money.Dollar(5);
            Assert.Equal(Money.Dollar(10), five.Times(2));
            Assert.Equal(Money.Dollar(15), five.Times(3));
        }
       
        // Equality
        [Fact]
        public void TestEquality()
        {       
            Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
        }


    }
}
