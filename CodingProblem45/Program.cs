class Program
{
    static void Main()
    {
        int[] tab = {4, 1, 3, 5, 6 };
        int index = 0;

        int? newIndex = IndexOfLargerInt(tab, index);
        Console.WriteLine(newIndex);
    }
    static int? IndexOfLargerInt(int[] tab, int index)
    {
        int? newIndex = null;
        for (int i = index; i < tab.Length; i++)
        {
            if (tab[i] > tab[index])
            {
                newIndex = i;
                break;
            }
        }
        for (int j = index; j >= 0; j--)
        {
            if (newIndex == null && tab[j] > tab[index])
            {
                newIndex = j;
                break;
            }
            else if (tab[j] > tab[index] && index - j < newIndex - index)
            {
                newIndex = j;
                break;
            }
        }
        return newIndex;
    }
}