class Program
{
    static void Main()
    {
        int binary = ConvertToBinary(156);
        int result = LongestConsecutiveRunOfOnes(binary);
        Console.WriteLine(result);

    }

    static int ConvertToBinary(int n)
    {
        string beforeReverseBinary = "";
        for (int i = n; i > 0; i /= 2)
        {
            int remainder = i % 2;
            beforeReverseBinary += remainder;
        }

        string binary = "";
        for (int i = beforeReverseBinary.Length - 1; i >= 0; i--)
        {
            binary += beforeReverseBinary[i];
        }

        return Convert.ToInt32(binary);
    }
    static int LongestConsecutiveRunOfOnes(int binary)
    {
        int n = 0;
        int largest = 0;
        for (int i = 0; i < binary.ToString().Length; i++)
        {
            if (binary.ToString()[i] == '1') n++;
            else
            {
                if (n > largest) largest = n;
                n = 0;
            }
        }
        return largest;
    }
}