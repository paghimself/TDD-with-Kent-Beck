using Xunit;
using TDD.Tools;

namespace TDD.Test.Tools
{
    public class FrancTests
    {
        [Fact]
        public void TestFrancMultiplicatoin()
        {
            Franc five = new Franc(5);
            Assert.Equal(new Franc(10), five.Times(2));
            Assert.Equal(new Franc(15), five.Times(3));
        }

        [Fact]
        public void TestFrancEquality()
        {
            Assert.True(new Franc(5).Equals(new Franc(5)));
            Assert.False(new Franc(5).Equals(new Franc(6)));
        }


    }
}
