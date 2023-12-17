using System;
class Program
{
    static void Main()
    {
        int[,] tab = { { 0, 0 }, { 1, 1 }, { 1, 2 }, { 3, 0 } };
        Console.WriteLine(NumberOfSteps(tab));
    }
    static int NumberOfSteps(int[,] tab)
    {
        int x = 0;
        int stepCounter = 0;
        for (int i = 0; i < tab.GetLength(0) - 1; i++)
        {
            while (tab[i, 0] != tab[i+1, 0] || tab[i, 1] != tab[i+1, 1])
            {
                if (tab[i, 0] != tab[i + 1, 0] && tab[i, 0] < tab[i+1,0])
                {
                    tab[i, 0]++;
                }
                else if (tab[i, 0] != tab[i + 1, 0] && tab[i, 0] > tab[i + 1, 0])
                {
                    tab[i, 0]--;
                }
                if (tab[i, 1] != tab[i + 1, 1] && tab[i, 1] < tab[i + 1, 1])
                {
                    tab[i, 1]++;
                }
                else if (tab[i, 1] != tab[i + 1, 1] && tab[i, 1] > tab[i + 1, 1])
                {
                    tab[i, 1]--;
                }
                stepCounter++;
            }
        }
        return stepCounter;
    }
}