class Program
{
    static void Main()
    {
        int[] tab = { 1, 2, 3, 4, 5 };
        int result = Sum(1, 3, tab);
        Console.WriteLine(result);
    }
    static int Sum(int i, int j, int[] tab)
    {
        int sum = 0;
        while (i < j)
        {
            sum += tab[i];
            i++;
        }
        return sum;
    }
}