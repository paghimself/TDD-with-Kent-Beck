using Xunit;
using TDD.Tools;

namespace TDD.Test.Tools
{
    public class DollarTests
    {
        [Fact]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Assert.Equal(new Dollar(10), five.Times(2));
            Assert.Equal(new Dollar(15), five.Times(3));
        }

        [Fact]
        public void TestEquality()
        {
            // Dollar
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
            
            // Franc
            Assert.True(new Franc(5).Equals(new Franc(5)));
            Assert.False(new Franc(5).Equals(new Franc(6)));

            // Between the two
            Assert.False(new Dollar(5).Equals(new Franc(5)));
        }
    }
}
