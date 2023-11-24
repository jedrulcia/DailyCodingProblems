internal class Program
{
    static void Main()
    {
        int[] tab = { 1, 2, 3, 4, 5, 6};
        tab = ReverseTab(tab);
        Array.ForEach(tab, Console.WriteLine);
    }
    static int[] ReverseTab(int[] tab )
    {
        int holder;
        for (int i = 0; i < tab.Length/2; i ++)
        {
            holder = tab[i];
            tab[i] = tab[tab.Length - 1 - i];
            tab[tab.Length - 1 - i] = holder;
        }
        return tab;
    }
}
