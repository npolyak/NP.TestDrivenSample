using NP.Utilities;
using Xunit;

namespace NP.Utility.Tests
{
    public static class Test_StringUtils
    {
        [Theory] // Theory attribute makes it an XUnit test with possible various combinations of input arguments
        [InlineData(1, "Hello World!", "ll", "He", "o World!")]
        [InlineData(2, "Hello World!", "Hel", "", "lo World!")]
        [InlineData(3, "Hello World!", "d!", "Hello Worl", "")]
        [InlineData(4, "Hello World!", null, "Hello World!", "")]
        [InlineData(5, "Hello World!", "1234", "Hello World!", "")]
        [InlineData(6, "Hello World!", "l", "He", "lo World!")]
        public static void BreakStringIntoTwoParts_Test
        (
            double testOrder,
            string str, 
            string? separator,
            string? expectedStartStrPart, 
            string? expectedEndStrPart
        )
        {
            // break string into two parts
            (string startStrPart, string endStrPart) = str.BreakStringIntoTwoParts(separator);

            // error out if the expected parts do not match the corresponding real part
            Assert.Equal(expectedStartStrPart, startStrPart);
            Assert.Equal(expectedEndStrPart, endStrPart);
        }
    }
}
