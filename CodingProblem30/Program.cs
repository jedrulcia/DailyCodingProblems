class Program
{
    static void Main()
    {
        int[,] matrix = {   { 0, 3, 1, 1 },
                            { 2, 0, 0, 4 },
                            { 1, 5, 3, 1 } };
        Sum(matrix, 0, 0, 0);
        FindLargestSum();
    }
    static int[] sums = new int[0];
    static void Sum(int[,] matrix, int xIndex, int yIndex, int sum)
    {
        sum += matrix[xIndex, yIndex];
        if (xIndex + 1 == matrix.GetLength(0) && yIndex + 1 == matrix.GetLength(1))
        {
            Array.Resize(ref sums, sums.Length + 1);
            sums[sums.Length - 1] = sum;
            return;
        }
        if (xIndex + 1 < matrix.GetLength(0))
        {
            Sum(matrix, xIndex + 1, yIndex, sum);
        }
        if (yIndex + 1 < matrix.GetLength(1))
        {
            Sum(matrix, xIndex, yIndex + 1, sum);
        }
    }
    static void FindLargestSum()
    {
        int largestSum = 0;
        for (int i = 0; i < sums.Length; i++)
        {
            if (sums[i] > largestSum)
            {
                largestSum = sums[i];
            }
        }
        Console.WriteLine($"Maximum number of coins you can collect by the bottom right corner is {largestSum}.");
    }
}