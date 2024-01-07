class Program
{
    static void Main()
    {
        string text = "waterrfetawx";
        int n = 3;
        DeleteLetter(text, n, 0);
    }
    static void DeleteLetter(string text, int n, int counter)
    {
        isPalindrome(text, counter);
        string holder = "";
        if (n > 0)
        {
            for (int i = 0; i < text.Length; i++)
            {
                holder = text.Remove(i, 1);
                isPalindrome(holder, counter + 1);
                DeleteLetter(holder, n - 1, counter + 1);
            }
        }
    }
    static void isPalindrome(string text, int counter)
    {
        for (int index = 0, backIndex = text.Length - 1; index < text.Length; index++, backIndex--)
        {
            if (text[index] != text[backIndex])
            {
                return;
            }
        }
        Console.WriteLine($"After removing {counter} letters, the text became palindrome: {text}");
        System.Environment.Exit(0);
    }
}