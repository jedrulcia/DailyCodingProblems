class Program
{
    static void Main()
    {
        int[,] tab = {  { 1, 2, 3 }, 
                        { 4, 5, 6 }, 
                        { 7, 8, 9 } };
        int[,] rotatedTab = RotateTab(tab);

        for (int i = 0; i < rotatedTab.GetLength(0); i++)
        {
            for (int j = 0; j < rotatedTab.GetLength(1); j++)
            {
                Console.Write(rotatedTab[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static int[,] RotateTab(int[,] tab)
    {
        int[,] rotatedTab = new int[tab.GetLength(0), tab.GetLength(1) ];
        for(int i = 0; i < tab.GetLength(1); i++)
        {
            for (int j = tab.GetLength(0) - 1; j >= 0; j--)
            {
                rotatedTab[i, (j - tab.GetLength(0) + 1) * (-1)] = tab[j, i];
            }
        }
        return rotatedTab;
    }
}