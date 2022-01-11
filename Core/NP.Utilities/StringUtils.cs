namespace NP.Utilities
{
    public static class StringUtils
    {
        public static (string start, string? end) BreakIntoTwoParts(this string str, string? separator)
        {
            string start = str, end = String.Empty;

            if (separator == null)
            {
                return (start, end);
            }

            int separatorIdx = str.IndexOf(separator);

            int firstPartLen = separatorIdx;

            if (separatorIdx < 0)
            {
                firstPartLen = str.Length;
            }
            
            start = str.Substring(0, firstPartLen);

            if (separatorIdx >= 0)
            {
                int secondPartIdx = separatorIdx + separator.Length;

                end = str.Substring(secondPartIdx);
            }
            else
            {
                end = String.Empty;
            }

            return (start, end);
        }
    }
}