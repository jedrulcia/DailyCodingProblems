class Program
{
    static void Main()
    {
        int[] tab = { -9, -2, 0, 2, 3 };

        SquareElements(tab);
        SortTheTab(tab);
    }

    static void SortTheTab(int[] tab)
    {
        for (int i = 0; i < tab.Length; i++)
        {
            for (int j = i + 1; j < tab.Length; j++)
            {
                if (tab[i] > tab[j])
                {
                    int holder = tab[i];
                    tab[i] = tab[j];
                    tab[j] = holder;
                }
            }
        }
    }

    static void SquareElements(int[] tab)
    {
        for (int i = 0; i < tab.Length; i++)
        {
            tab[i] = tab[i] * tab[i];
        }
    }
}