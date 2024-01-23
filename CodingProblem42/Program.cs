using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] matrix = {
                            {1, 0, 0, 0},
                            {1, 0, 1, 1},
                            {1, 0, 1, 1},
                            {0, 1, 0, 0}
        };
        int largestRectangle = MaximalRectangle(matrix);
        Console.WriteLine($"Largest rectangle area: {largestRectangle}");
    }
    static int MaximalRectangle(int[,] matrix)
    {
        int[] heights = new int[matrix.GetLength(1)];
        int largestRectangle = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 1)
                    heights[j]++;
                else
                    heights[j] = 0;
            }
            largestRectangle = Math.Max(largestRectangle, LargestRectangle(heights));
        }

        return largestRectangle;
    }
    static int LargestRectangle(int[] heights)
    {
        Stack<int> stack = new Stack<int>();
        int largestRectangle = 0;

        for (int i = 0; i <= heights.Length; i++)
        {
            while (stack.Count > 0 && (i == heights.Length || heights[i] < heights[stack.Peek()]))
            {
                int height = heights[stack.Pop()];
                int width = stack.Count > 0 ? i - stack.Peek() - 1 : i;
                largestRectangle = Math.Max(largestRectangle, height * width);
            }

            stack.Push(i);
        }
        return largestRectangle;
    }

}
