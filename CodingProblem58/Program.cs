using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        WhichGameShouldAlicePlay();
    }
    static int RollDice(int firstValue, int followingValue)
    {
        Random random = new Random();
        bool isConditionMet = false;
        int firstHolder = 0, secondHolder = 0, counter = 0;

        while (isConditionMet == false)
        {
            counter++;
            firstHolder = secondHolder;
            secondHolder = random.Next(1, 7);
            if (firstHolder == firstValue && secondHolder == followingValue) isConditionMet = true;
        }
        return counter;
    }
    static void WhichGameShouldAlicePlay()
    {
        int firstSumOfPayments = 0;
        int secondSumOfPayments = 0;

        for (int i = 0; i < 10000; i++)
        {
            firstSumOfPayments += RollDice(5, 6);
            secondSumOfPayments += RollDice(5, 5);
        }
        int averageFirstPayments = firstSumOfPayments / 10000;
        int averageSecondPayments = secondSumOfPayments / 10000;
        string aliceShouldPlay = "";

        if (averageFirstPayments < averageSecondPayments) aliceShouldPlay = "first game";
        else if (averageFirstPayments > averageSecondPayments) aliceShouldPlay = "second game";
        else aliceShouldPlay = "it does not matter";

        Console.WriteLine($"Alice should play: {aliceShouldPlay}.");
    }
}