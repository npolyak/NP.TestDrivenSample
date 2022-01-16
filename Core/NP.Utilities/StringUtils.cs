namespace NP.Utilities
{
    public static class StringUtils
    {
        public static (string startStrPart, string endStrPart) BreakStringIntoTwoParts(this string str, string separator)
        {
            // initialize the indexes 
            // to return first part as full string 
            // and second part as emtpy string
            int separatorIdx = str.Length;
            int endPartBeginIdx = str.Length;

            // assign the separatorIdx and endPartBeginIdx
            // only if the separator is not null in 
            // order to avoid an exception through 
            // by str.IndexOf(separator)
            if (separator != null)
            {
                int realSeparatorIdx = str.IndexOf(separator);

                // only assing indexes if realSeparatorIdx is not
                // -1, e.i. if separator is found within str.
                if (realSeparatorIdx != -1)
                {
                    // get the index of the first instance of the 
                    // separator within the string. 
                    separatorIdx = str.IndexOf(separator);

                    // we get the index after the separator end:
                    endPartBeginIdx = separatorIdx + separator.Length;
                }
            }

            // we get the first part of the result - 
            // part between index 0 and separatorIdx
            string startStrPart = str.Substring(0, separatorIdx);

            // we get the second part of the result:
            string endStrPart = str.Substring(endPartBeginIdx);

            return (startStrPart, endStrPart);
        }
    }
}