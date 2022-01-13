namespace NP.Utilities
{
    public static class StringUtils
    {
        public static (string startStrPart, string endStrPart) BreakStringIntoTwoParts(this string str, string separator)
        {
            int separatorIdx = str.Length;
            int endPartBeginIdx = str.Length;

            if (separator != null)
            {
                int realSeparatorIdx = str.IndexOf(separator);

                if (realSeparatorIdx != -1)
                {
                    separatorIdx = realSeparatorIdx;

                    endPartBeginIdx = separatorIdx + separator.Length;
                }
            }

            string startStrPart = str.Substring(0, separatorIdx);

            string endStrPart = str.Substring(endPartBeginIdx);

            return (startStrPart, endStrPart);
        }

    }
}