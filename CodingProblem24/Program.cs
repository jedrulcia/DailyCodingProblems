class Program
{
    static void Main()
    {
        int[] tab1 = { 2, 0, 1, 0 };
        bool n1 = ReachLastIndex(tab1);
        Console.WriteLine(n1);

        int[] tab2 = { 1, 1, 0, 0 };
        bool n2 = ReachLastIndex(tab2);
        Console.WriteLine(n2);
    }
    static bool ReachLastIndex(int[] tab)
    {
        int n = 0;
        while (n < tab.Length - 1)
        {
            if (tab[n] == 0)
            {
                return false;
            }
            n = n + tab[n];
        }
        return true;
    }
}