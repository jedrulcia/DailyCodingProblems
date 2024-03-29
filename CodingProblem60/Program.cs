class Program
{
    static void Main()
    { 
        Console.WriteLine(isPalindrome(121));
        Console.WriteLine(isPalindrome(678));
    }
    static bool isPalindrome(int n)
    {
        int k = n;
        int reverted = 0;
        int multiplier = 1;
        while (multiplier < k)
        {
            multiplier *= 10;
        }
        multiplier /= 10;
        while (k != 0)
        {
            int holder = k % 10;
            k /= 10;
            reverted += (holder * multiplier);
            multiplier /= 10;
        }
        if (reverted == n)return true;
        else return false;
    }
}