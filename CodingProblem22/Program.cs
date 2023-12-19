class Program
{
    static void Main()
    {
        int evenNumber = 16;
        int[] primeNumbers = PrimeNumbers(evenNumber);
        SumOfPrimeNumbers(primeNumbers, evenNumber);
    }
    static void SumOfPrimeNumbers(int[] primeNumbers, int evenNumber)
    {
        bool metCondition = false;
        for (int i = 0; i < primeNumbers.Length; i++)
        {
            for (int j = i; j < primeNumbers.Length; j++)
            {
                if (primeNumbers[i] + primeNumbers[j] == evenNumber)
                {
                    Console.WriteLine($"{primeNumbers[i]} + {primeNumbers[j]} == {evenNumber}");
                    metCondition = true;
                    break;
                }
            }
            if (metCondition == true)
            {
                break;
            }
        }
    }
    static int[] PrimeNumbers(int n)                                    //Method which creates an array of prime numbers
    {
        int[] primeNumbers = new int[0];
        int x = 0;
        for (int i = 2; i < n+1; i++)
        {
            int divider = 2;
            while (divider < n + 1)
            {
                if (i % divider == 0 && i/divider != 1)
                {
                    break;
                }
                else if (i % divider == 0 && i/divider == 1)
                {
                    x++;
                    Array.Resize(ref primeNumbers, x);
                    primeNumbers[x - 1] = i;
                    break;
                }
                divider++;
            }
        }
        return primeNumbers;
    }
}