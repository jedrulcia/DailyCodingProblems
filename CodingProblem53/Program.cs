class Program
{
    static void Main()
    {
        int[,] matrix = {   { 0, 0, 1 }, { 0, 0, 0 }, { 1, 0, 0 } };
        int counter = 0;
        CountWaysToDestination(matrix, 0, 0, ref counter);
        Console.WriteLine(counter);
    }
    static void CountWaysToDestination(int[,] matrix, int i, int j, ref int counter)
    {
        if (i == matrix.GetLength(0) - 1 && j == matrix.GetLength(1) - 1) counter++;
        else if (matrix[i, j] == 0)
        {
            if (i + 1 < matrix.GetLength(0)) CountWaysToDestination(matrix, i + 1, j, ref counter);
            if (j + 1 < matrix.GetLength(1)) CountWaysToDestination(matrix, i, j + 1, ref counter);
        }
    }
}