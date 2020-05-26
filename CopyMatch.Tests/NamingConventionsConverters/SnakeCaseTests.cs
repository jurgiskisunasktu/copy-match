using CopyMatch.NamingConventionsConverters;
using Xunit;

namespace CopyMatch.Tests.NamingConventionsConverters
{
    public class SnakeCaseTests
    {
        [Theory]
        [InlineData("snake case", "snake_case")]
        [InlineData("snake", "snake")]
        public static void StringToThisTest(string input, string expected)
        {
            SnakeCase cc = new SnakeCase();
            string result = cc.StringToThis(input);

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData("snake_case", "snake case")]
        [InlineData("snake", "snake")]
        public static void ThisToStringTest(string input, string expected)
        {
            SnakeCase cc = new SnakeCase();
            string result = cc.ThisToString(input);

            Assert.Equal(result, expected);
        }
    }
}
