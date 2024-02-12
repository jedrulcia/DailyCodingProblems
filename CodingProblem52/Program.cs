class Program
{
    static void Main()
    {
        string word = "carrace";
        Console.WriteLine(CanBePalindrome(word));
    }
    static bool CanBePalindrome(string word)
    {
        word = Sort(word);
        int counter = 0;
        for (int i = 1; i < word.Length; i++)
        {
            if (word[i] == word[i - 1]) i++;
            else counter++;
        }
        if (counter == 0 || (word.Length % 2 == 1 && counter == 1)) return true;
        else return false;
    }
    static string Sort(string word)
    {
        char[] characters = word.ToCharArray();
        Array.Sort(characters);
        return new string(characters);
    }
}