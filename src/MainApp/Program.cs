using NP.Utilities;

string str = "Hello World!";
string separator = "ll"; // startStrPart="He" endStrPart="o World!"

// use the method to obtain the start and the end parts of the result:
(string startStrPart, string endStrPart) = str.BreakStringIntoTwoParts(separator);