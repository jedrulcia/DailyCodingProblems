class Program
{
    static void Main()
    {
        string text = "acbde";
        Console.WriteLine(FirstRecurringCharacter(text));
    }

    static char? FirstRecurringCharacter(string text)
    {
        for (int i = 1; i < text.Length; i++)
        {
            for (int j = i - 1; j > 0; j--)
            {
                if (text[i] == text[j]) return text[i];
            }
        }
        return null;
    }
}