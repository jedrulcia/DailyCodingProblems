class Program
{
    static void Main()
    {
        int n = 5;
        Console.WriteLine(Coins(n));
    }
    static int Coins(int n)
    {
        int count = 0;
        while (n != 1)
        {
            int holder = n % 2;
            n = n - holder;
            n = n / 2;
            count++;
        }
        return count;
    }
}