namespace daily1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 17;
            int[] tab = { 10, 15, 3, 7 };
            Console.WriteLine(Number(n, tab));
        }
        static bool Number(int n, int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length; j++)
                {
                    if (tab[j] + tab[i] == n)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}