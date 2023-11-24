namespace CodingProblem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prefix = "des";
            string[] tab = { "dog", "deer", "deal", "destiny", "ode"};
            string[] matches = MatchPrefix(tab, prefix);
            Array.ForEach(matches, Console.WriteLine);
        }
        static string[] MatchPrefix(string[] tab, string prefix)
        {
            string[] matches = new string[0];
            int x = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i].Substring(0, prefix.Length) == prefix)
                {
                    Array.Resize(ref matches, matches.Length +1);
                    matches[x] = tab[i];
                    x++;
                }
            }
            return matches;
        }
    }
}