class Program
{
    static void Main()
    {
        string text = "abracadabra";
        string pattern = "abr";

        int[] startingIndicies = FindStartingIndicies(text, pattern);
        Array.ForEach(startingIndicies, Console.Write);
    }
    static int[] FindStartingIndicies(string text, string pattern)
    {
        int[] startingIndicies = new int[0];

        for (int i = 0; i < text.Length - pattern.Length; i++)
        {
            if (text.Substring(i, pattern.Length) == pattern)
            {
                Array.Resize(ref startingIndicies, startingIndicies.Length + 1);
                startingIndicies[startingIndicies.Length - 1] = i;
            }
        }
        return startingIndicies;
    }
}