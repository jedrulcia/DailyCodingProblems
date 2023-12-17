class Program
{
    static void Main()
    {
        int[] tab = {100, 4, 200, 1, 3, 2 };
        Console.WriteLine(LongestConsecutiveElements(tab));
    }
    static int LongestConsecutiveElements(int[] tab)
    {
        int holder, counter;
        int longestConsecutive = 0;
        for (int i = 0; i<tab.Length; i++)
        {
            counter = 1;
            holder = tab[i];
            for (int j = 0; j<tab.Length; j++)
            {
                if (tab[j] == holder + 1)
                {
                    counter++;
                    j = -1;
                    holder++;
                }
            }
            if (counter > longestConsecutive)
            {
                longestConsecutive = counter;
            }
        }
        return longestConsecutive;
    }
}