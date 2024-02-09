class Program
{
    static Random random = new Random();
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4 };
        double[] probabilities = { 0.1, 0.5, 0.2, 0.2 };
        for(int i = 10; i > 0; i--) Console.Write(GenerateNumber(numbers, probabilities) + " ");
    }
    static int GenerateNumber(int[] numbers, double[] probabilities)
    {
        double holder = random.NextDouble();
        int currentIndex = 0;
        while (holder > 0)
        {
            holder -= probabilities[currentIndex];
            if(holder > 0) currentIndex++;
        }
        return numbers[currentIndex];
    }
}