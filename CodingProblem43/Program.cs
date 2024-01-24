class Program
{
    static void Main()
    {
        int[] americanCoins = { 1, 5, 10, 25 };
        int n = 16;
        int coinsNumber = MinimunNumberOfCoins(americanCoins, n);
        Console.WriteLine(coinsNumber);
    }
    static int MinimunNumberOfCoins(int[] americanCoins, int n)
    {
        int holder = 0, coinsCounter = 0;
        for (int i = americanCoins.Length - 1; i >= 0; i--)
        {
            while (holder < n)
            {
                holder += americanCoins[i];
                coinsCounter++;
            }
            if (holder > n)
            {
                holder -= americanCoins[i];
                coinsCounter--;
            }
            if (holder == n) break;
        }
        return coinsCounter;
    }
}