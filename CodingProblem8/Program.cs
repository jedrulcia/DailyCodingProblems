namespace CodingProblem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] tab = { 'R', 'B', 'G', 'G', 'B', 'G', 'G', 'B', 'B', 'B', 'R', 'B' };
            char[] segregated = Segregate(tab);
            Array.ForEach(segregated, Console.WriteLine);
        }
        static char[] Segregate(char[] tab)
        {
            int start = 0;
            int end = tab.Length - 1;
            char holder;
            for (int i = 0; i < end; i++)
            {
                if (tab[end] == 'B')
                {
                    end--;
                }
                if (tab[i] == 'B' && i < end)
                {
                    holder = tab[end];
                    tab[end] = 'B';
                    tab[i] = holder;
                    end--;
                }
                if (tab[i] == 'R')
                {
                    holder = tab[start];
                    tab[start] = 'R';
                    tab[i] = holder;
                    start++;
                }
            }
            return tab;
        }
    }
}