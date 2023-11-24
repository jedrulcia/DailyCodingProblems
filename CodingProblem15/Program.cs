class Program
{
    static void Main()
    {
        int n = 6;
        int x = 12;
        int[,] tab = GenerateArray(n);
        int counter = TimesXAppearInArray(tab, x, n);
        Console.WriteLine(counter);
    }
    static int[,] GenerateArray(int n)
    {
        int[,] tab = new int[n, n];
        for(int i = 0; i< tab.Length/n; i++)
        {
            tab[i, 0] = i + 1;
            for (int j = 1; j < tab.Length/n; j++)
            {
                tab[i, j] = tab[i, 0] * (j + 1);
            }
        }
        return tab;
    }
    static int TimesXAppearInArray(int[,] tab, int x, int n)
    {
        int counter = 0;
        for (int i = 0; i < tab.Length / n; i++)
        {
            for (int j = 0; j < tab.Length / n; j++)
            {
                if (tab[i, j] == x)
                {  
                    counter++; 
                }
            }
        }
        return counter;
    }

}