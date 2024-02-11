class Program
{
    static void Main()
    {
        int smallestNumber = SmallestNumberOfSquaredIntegers(41);
        Console.WriteLine(smallestNumber);
    }
    static int SmallestNumberOfSquaredIntegers (int n)
    {
        int counter = 0;
        int smallestCounter = 0;
        double sum = 0;
        double startingIndex = Math.Floor(Math.Sqrt(n));
        for (double j = startingIndex; j > 0; j--)
        {
            for (double i = j; i > 0; i--)
            {
                if (sum + Math.Pow(i, 2) <= n)
                {
                    sum += Math.Pow(i, 2);
                    counter++;
                    i++;
                }
            }
            if (smallestCounter == 0 || counter < smallestCounter)  smallestCounter = counter;
            sum = 0;
            counter = 0;
        }
        return smallestCounter;
    }
}