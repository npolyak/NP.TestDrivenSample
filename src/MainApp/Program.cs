
using NP.Utilities;

string str = "Hello World!";
string separator = "ll"; // startStrPart="He" endStrPart="o World!"

(string startStrPart, string endStrPart) = str.BreakStringIntoTwoParts(separator);

