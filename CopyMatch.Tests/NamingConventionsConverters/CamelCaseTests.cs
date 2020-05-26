using CopyMatch.NamingConventionsConverters;
using Xunit;

namespace CopyMatch.Tests.NamingConventionsConverters
{
    public class CamelCaseTests
    {
        [Theory]
        [InlineData("camel case", "CamelCase")]
        [InlineData("camel", "Camel")]
        public static void StringToThisTest(string input, string expected)
        {
            CamelCase cc = new CamelCase();
            string result = cc.StringToThis(input);

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData("CamelCase", "camel case")]
        [InlineData("Camel", "camel")]
        public static void ThisToStringTest(string input, string expected)
        {
            CamelCase cc = new CamelCase();
            string result = cc.ThisToString(input);

            Assert.Equal(result, expected);
        }
    }
}
