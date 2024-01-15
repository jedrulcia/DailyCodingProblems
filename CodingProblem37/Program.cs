class Program
{
    static void Main()
    {
        int n = 9;
        int SquareRoot = FindTheSquareRoot(n);
        if (SquareRoot == -1)
        {
            Console.WriteLine($"Real number {n} doesn't have a square root.");
        }
        else
        {
            Console.WriteLine($"Real number {n} has a square root that equals {SquareRoot}.");
        }
    }
    static int FindTheSquareRoot(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            if (i * i == n)
            {
                return i;
            }
        }
        return -1;
    }
}