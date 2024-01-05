using System.Diagnostics.Tracing;

class Program
{
    static void Main()
    {
        string text = "hello world here";
        string[] words = StoringSingleWords(text);
        string reversedText = ReversingText(words);
        Console.WriteLine(reversedText);
    }

    static string ReversingText(string[] words)
    {
        string reversedText = "";
        for (int i = words.Length; i > 0; i--)
        {
            reversedText += words[i - 1];
            if (i == words.Length)                                  //This if statement adds space to the first string in the tab
            {
                reversedText += " "; 
            }
        }
        return reversedText;
    }

    static string[] StoringSingleWords(string text)
    {
        string[] words = new string[0];
        string holder = "";

        for (int i = 0; i < text.Length; i++)
        {
            if (text.Substring(i, 1) == " " || i + 1 == text.Length)
            {
                holder += text.Substring(i, 1);
                Array.Resize(ref words, words.Length + 1);
                words[words.Length - 1] = holder;
                holder = "";
            }
            else
            {
                holder += text.Substring(i, 1);
            }
        }

        return words;
    }
}