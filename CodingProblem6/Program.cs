namespace CodingProblem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 10, 5, 2, 7, 8, 7};
            int k = 3;
            int[] maxValues = MaxValues(tab, k);
            Array.ForEach(maxValues, Console.WriteLine);
        }
        static int[] MaxValues(int[] tab, int k)
        {
            int[] tab2 = new int[tab.Length - k + 1];
            for (int i = 0; i < tab.Length - k + 1; i++)
            {
                int x = 0;
                for (int j = 0; j < k; j++)
                {
                    if (tab[i + j] > x)
                    {
                        x = tab[i + j];
                    }
                }
                tab2[i] = x;
            }
            return tab2;
        }
    }
}