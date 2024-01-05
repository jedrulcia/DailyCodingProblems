class Program
{
    static void Main()
    {
        int[,] tab = { { 3, 4 }, { 6, 9 }, { 2, 6 }, { 0, 3 } };

        int[] smallestSetOfNumbers = SmallestSetOfNUmbers(tab);
        Array.ForEach(smallestSetOfNumbers, Console.WriteLine);
    }

    static int[] SmallestSetOfNUmbers(int[,] tab)
    {
        for (int i = 0; i < tab.GetLength(0); i++)
        {
            for (int j = i + 1; j < tab.GetLength(0); j++)
            {
                if (tab[i, 0] > tab[j, 0])
                {
                    int holder = tab[i, 0];
                    int holder2 = tab[i, 1];
                    tab[i, 0] = tab[j, 0];
                    tab[i, 1] = tab[j, 1];
                    tab[j, 0] = holder;
                    tab[j, 1] = holder2;
                }
            }
        }
        int index = tab.GetLength(0) - 1;
        int[] smallestSetOfNumbers = { tab[0, 1], tab[index, 0] };

        return smallestSetOfNumbers;
    }
}