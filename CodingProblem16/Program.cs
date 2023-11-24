using System.Dynamic;

class Program
{
    static void Main()
    {
        char[,] tab = { {'c','b','a' },{'d','a','f' }, { 'g','h','i'} };
        int count = CountDeletedColumns(tab);
        Console.WriteLine(count);
    }

    static int CountDeletedColumns(char[,] tab)
    {
        int count = 0;
        char[] holder1 = new char[tab.GetLength(0)];
        for (int i = 0; i < tab.GetLength(1); i++)
        {
            string holder = "";
            for (int j = 0; j < tab.GetLength(0); j++)
            {
                holder = holder + tab[j, i];
                holder1[j] = tab[j, i];
            }
            Array.Sort(holder1);
            string sorted = new string(holder1);
            if (holder != sorted)
            {
                count++;
            }
        }
        return count;
    }
}