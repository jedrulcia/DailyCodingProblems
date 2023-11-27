class Program
{
    static void Main()
    {
        int[] tab = { 1, 2, 3, 7, 4, 5, 6, 7};
        Console.WriteLine(NonDecreaseArray(tab));
    }
    static bool NonDecreaseArray(int[] tab)
    {
        int bigCounter = 0;                             // variable to count values which are bigger than the values with the bigger index in the array
        int smallCounter = 0;                           // variable to count values which are smaller than the values with the smaller index in the array
        for (int i = 0; i < tab.Length; i++)
        {
            int counter = 0;
            int holder = -1;
            for (int j = i + 1; j < tab.Length; j++)
            {
                if (tab[i] > tab[j])
                {
                    counter++;
                    holder = j;
                }
            }
            if (counter > 1)
            {
                bigCounter++;
            }
            else if (counter == 1 && holder == tab.Length - 1)
            {
                smallCounter++;
            }

            if (bigCounter > 0 && smallCounter > 0)     // if there is 'bigger value' and 'smaller value' in the array, it means that array cannot become non-decreasing by modifying at most 1 element
            {
                return false;
            }
            else if (bigCounter > 1)                    // id there is more than one 'bigger value', it means that array cannot become non-descreasing by modifying at most 1 element   
            {
                return false;
            }
        }
        return true;
    }
}