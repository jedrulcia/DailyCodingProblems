namespace daily2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 4, 5 };
            tab = PowerTab(tab);
            Array.ForEach(tab, Console.WriteLine);
        }
        static int[] PowerTab(int[] tab)
        {
            int[] tab2 = new int[tab.Length];
            for(int i = 0; i < tab.Length; i++)
            {
                int x = 1;
                for (int j = 0;j<tab.Length;j++)
                {
                    if (i != j)
                    {
                        x = x * tab[j];
                    }
                }
                tab2[i] = x;
            }
            return tab2;
        }
    }
}