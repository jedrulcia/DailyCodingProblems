class Program
{
    static void Main()
    {
        int[] tab = { 1, 2, 3, 4, 5, 6 };
        int k = 5;
        tab = ReverseElements(tab, k);
        Array.ForEach(tab, Console.Write);
    }
    static int[] ReverseElements(int[] tab, int k)
    {
        for (int i = 0; i < k; i++)
        {
            for (int j = tab.Length - k + i; j > i; j -= k)
            {
                int holder = tab[i];
                tab[i] = tab[j];
                tab[j] = holder;
            }
        }
        return tab;
    }
}