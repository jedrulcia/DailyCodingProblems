class Program
{
    static void Main()
    {
        int[,] tab = { { 1, 3 }, { 5, 8 }, { 4, 10 }, { 20, 25 } };
        bool needSort = true;
        int[,] tab2 = OverlappingIntervals(tab, needSort);
        for (int i = 0; i < tab2.GetLength(0); i++)
        {
            Console.Write(tab2[i, 0]);
            Console.Write(' ');
            Console.Write(tab2[i, 1]);
            Console.WriteLine();
        }
    }
    static int[,] OverlappingIntervals(int[,] tab, bool needSort)
    {
        needSort = false;
        int x = 2;
        int[] tab2 = new int[0];
        for (int i = 0; i < tab.GetLength(0); i++)
        {
            if (i + 1 == tab.GetLength(0))
            {
                Array.Resize(ref tab2, x);
                tab2[x - 2] = tab[i, 0];
                tab2[x - 1] = tab[i, 1];
                x = x + 2;
                break;
            }
            if (tab[i, 1] >= tab[i + 1, 0] && tab[i, 0] <= tab[i + 1, 0])
            {
                needSort = true;
                Array.Resize(ref tab2, x);
                tab2[x - 2] = tab[i, 0];
                tab2[x - 1] = tab[i + 1, 1];
                x = x + 2;
                i++;
            }
            else if (tab[i, 1] >= tab[i + 1, 0] && tab[i, 0] > tab[i + 1, 0])
            {
                needSort = true;
                Array.Resize(ref tab2, x);
                tab2[x - 2] = tab[i + 1, 0];
                tab2[x - 1] = tab[i + 1, 1];
                x = x + 2;
                i++;
            }
            else
            {
                Array.Resize(ref tab2, x);
                tab2[x - 2] = tab[i, 0];
                tab2[x - 1] = tab[i, 1];
                x = x + 2;
            }
        }
        int[,] tab3 = new int[tab2.Length / 2, 2];
        int y = 2;
        for (int i = 0; i < tab2.Length / 2; i++)
        {
            tab3[i, 0] = tab2[y - 2];
            tab3[i, 1] = tab2[y - 1];
            y = y + 2;
        }
        if (needSort == true)
        {
            tab3 = OverlappingIntervals(tab3, false);
        }
        return tab3;
    }
}