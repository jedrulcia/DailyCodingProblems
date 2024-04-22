using System;
class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 10 };
        Console.WriteLine(FindSmallestMissingPositive(arr));
    }
    static int FindSmallestMissingPositive(int[] arr)
    {
        int smallestMissing = 1;
        for (int i = 0; i < arr.Length && arr[i] <= smallestMissing; i++) smallestMissing += arr[i];
        return smallestMissing;
    }
}
