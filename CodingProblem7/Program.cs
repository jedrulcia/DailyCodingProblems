namespace CodingProblem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 6, 1, 3, 3, 3, 6, 6 };
            int[] unique = UniqueNumbers(tab);
            Array.ForEach(unique, Console.WriteLine);
        }
        static int[] UniqueNumbers(int[] tab)
        {
            int z = 0;
            int[] uniqueTab = new int[0];
            for (int i = 0; i < tab.Length; i++)
            {
                int x = 0;
                for (int j = 0; j < tab.Length; j++)
                {
                    if (tab[i] == tab[j] && i != j)
                    {
                        x++;
                    }
                }
                if (x == 0)
                {
                    Array.Resize(ref uniqueTab, uniqueTab.Length + 1);
                    uniqueTab[z] = tab[i];
                    z++;
                }
            }
            return uniqueTab;
        }
    }
}