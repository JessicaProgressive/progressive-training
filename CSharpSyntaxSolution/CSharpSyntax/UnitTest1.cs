using Xunit.Sdk;

namespace CSharpSyntax
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 10, b = 5, actual;

            actual = a + b;

            Assert.Equal(15, actual);    
        }

        [Theory]
        [InlineData("J", false)]
        [InlineData("Jess", false)]
        [InlineData("Jessica", true)] 
        public void Test2(string str, bool expected)
        {
            bool actual = str == "Jessica";
            Assert.Equal(expected, actual);
        }
    }
}