namespace CodingProblem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int ways = WaysToClimb(n);
            Console.WriteLine(ways);
        }
        static int WaysToClimb(int n)
        {
            int ways = 0;
            int numerator, denominator;
            for (int k = 0; k <= n; k++, n--)
            {
                numerator = Factorial(n);
                denominator = Factorial(k)*Factorial(n-k);
                ways = ways + (numerator / denominator);
            }
            return ways;
        }
        static int Factorial(int n)
        {
            if (n < 2)
            {
                return 1;
            }
            return Factorial(n - 1) * n;
        }
    }
}