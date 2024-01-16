class Program
{
    static void Main()
    {
        int[] stockPrices = { 5, 2, 4, 0, 1 };
        int k = 2;
        int maximumprofit = MaximumProfit(stockPrices, k);
        
        Console.WriteLine(maximumprofit);
    }
    static int MaximumProfit(int[] stockPrices, int k)
    {
        int[] profits = new int[0]; 
        for(int i = 0; i < stockPrices.Length; i++)
        {
            for (int j = i + 1; j < stockPrices.Length; j++)
            {
                
                int currentProfit = stockPrices[j] - stockPrices[i];
                Array.Resize(ref profits, profits.Length + 1);
                profits[profits.Length - 1] = currentProfit;
            }
        }
        Array.Sort(profits);

        int maximumProfit = 0;
        for (int i = profits.Length - 1; k > 0; i--, k--)
        {
            maximumProfit += profits[i];
        }

        return maximumProfit;
    }
}