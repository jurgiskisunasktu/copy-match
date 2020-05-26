using CopyMatch.NamingConventionsConverters;
using Xunit;

namespace CopyMatch.Tests.NamingConventionsConverters
{
    public class KebabCaseTests
    {
        [Theory]
        [InlineData("kebab case", "kebab-case")]
        [InlineData("kebab", "kebab")]
        public static void StringToThisTest(string input, string expected)
        {
            KebabCase cc = new KebabCase();
            string result = cc.StringToThis(input);

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData("kebab-case", "kebab case")]
        [InlineData("kebab", "kebab")]
        public static void ThisToStringTest(string input, string expected)
        {
            KebabCase cc = new KebabCase();
            string result = cc.ThisToString(input);

            Assert.Equal(result, expected);
        }
    }
}
