using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine(IsNumber("10"));
        Console.WriteLine(IsNumber("-10"));
        Console.WriteLine(IsNumber("10.1"));
        Console.WriteLine(IsNumber("-10.1"));
        Console.WriteLine(IsNumber("1e5"));

        Console.WriteLine(IsNumber("a"));
        Console.WriteLine(IsNumber("x 1"));
        Console.WriteLine(IsNumber("a -2"));
        Console.WriteLine(IsNumber("-"));
    }

    static bool IsNumber(string text)
    {
        string patternInteger = @"^[+-]?\d+";
        string patternDecimal = @"^[+-]?\d+\.\d+";
        string patternScientificNotation = @"^[+-]?\d+\[eE]\[+-]?\d+";

        string[] patterns = {patternInteger, patternDecimal, patternScientificNotation};

        for (int i = 0; i<patterns.Length; i++)
        {
            if (Regex.IsMatch(text, patterns[i]))
            {
                return true;
            }
        }

        return false;
    }

}