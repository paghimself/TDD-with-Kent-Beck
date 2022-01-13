using TDD.Tools;
using Xunit;

namespace TDD.Test.Tools
{
    public class UnitTest1
    {
        [Fact]
        public void TestMultiplication()
        {
            var five = new Dollar(5);
            five.Times(2);
            Assert.Equal(10, five.Amount);
        }
    }
}
