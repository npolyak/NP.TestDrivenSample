
using NP.Utilities;

string str = "Hello World!";

(string start, string? end) = str.BreakIntoTwoParts("ll"); // should break it into "He" and "o World!"

Console.WriteLine($"Start='{start}'");
Console.WriteLine($"End='{end}'");