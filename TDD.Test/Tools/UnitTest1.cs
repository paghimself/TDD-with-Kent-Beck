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
            var product = five.Times(2);  
            Assert.Equal(10, product.Amount);
            product = five.Times(3);
            Assert.Equal(15, product.Amount);
        }
    }
}
