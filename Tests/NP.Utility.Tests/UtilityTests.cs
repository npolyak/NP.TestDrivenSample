using NP.Utilities;
using Xunit;

namespace NP.Utility.Tests
{
    public static class UtilityTests   
    {
        [Theory]
        [InlineData(1, "Hello World!", "ll", "He", "o World!")] // separator inside of the string
        [InlineData(2, "Hello World!", "He", "", "llo World!")] // separator in the beginning of the string
        [InlineData(3, "Hello World!", "orld!", "Hello W", "")] // separator in the end of the string
        [InlineData(4, "Hello World!", "Hi", "Hello World!", "")] // separator does not exist inside the string
        [InlineData(5, "Hello World!", null, "Hello World!", "")] // separator null
        public static void Test_BreakIntoTwoParts
        (
            double inlineDataOrder,
            string str, 
            string separator, 
            string? expectedStart, 
            string? expectedEnd)
        {
            (string start, string end) = str.BreakIntoTwoParts(separator);

            Assert.Equal(expectedStart, start);
            Assert.Equal(expectedEnd, end);
        }

    }
}