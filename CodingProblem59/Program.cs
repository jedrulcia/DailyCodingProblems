class Program
{
    static void Main()
    {
        int[] tab = { 42, 56, 14 };
        int greatestDenominator = FindGreatestDenominator(tab);
        Console.WriteLine(greatestDenominator);
    }
    static int FindGreatestDenominator(int[] tab)
    {
        int smallestNumber = FindSmallestNumber(tab);
        bool shouldContinue = true;

        while (shouldContinue)
        {
            shouldContinue = false;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % smallestNumber != 0)
                {
                    shouldContinue = true;
                    smallestNumber -= 1;
                    break;
                }
            }
        }
        return smallestNumber;
    }
    static int FindSmallestNumber(int[] tab)
    {
        int smallestNumber = tab[0];

        for (int i = 0; i < tab.Length; i++) if (tab[i] < smallestNumber) smallestNumber = tab[i];

        return smallestNumber;
    }
}