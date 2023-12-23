class Program
{
    static void Main()
    {
        int[] tab = { 1, 2, 4, 4, 6 };
        int n = 9;
        int[] contiguousElements = ContiguousElements(tab, n);

        if (contiguousElements != null )
        {
            Array.ForEach(contiguousElements, Console.WriteLine);
        }
        else
        {
            Console.WriteLine($"There is no such sequence which add up to {n}");
        }
    }
    static int[] ContiguousElements(int[] tab, int n)
    {
        for (int i = 0; i< tab.Length; i++)
        {
            int[] contiguousElements = new int[0];
            int sum = 0;
            int x = 0;
            for (int j = i + 1; j < tab.Length; j++)
            {
                x++;
                Array.Resize(ref contiguousElements, x);
                contiguousElements[x-1] = tab[j];
                sum = sum + tab[j];
                if (sum == n)
                {
                    return contiguousElements;
                }
                else if (sum > n)
                {
                    break;
                }
            }
        }
        return null;
    }
}