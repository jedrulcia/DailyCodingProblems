namespace CodingProblem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 0, 1, 2, 4, 5, 6 };
            int n = LowestPositive(tab);
            Console.WriteLine(n);
        }
        static int LowestPositive(int[] tab)
        {
            for(int i = 1;i<tab.Length +2 ; i++)
            {
                int x = 0;
                for(int j = 0; j<tab.Length; j++)
                {
                    if(i != tab[j])
                    {
                        x++;
                    }
                }
                if (x == tab.Length)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}