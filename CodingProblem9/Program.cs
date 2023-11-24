namespace CodingProblem9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 2, 1, 5, 7, 2, 0, 5 };
            Median(tab);
        }
        static void Median(int[] tab)
        {
            double[] holder = new double[0];
            for (int i = 0; i < tab.Length; i++)
            {
                Array.Resize(ref holder, i + 1);
                holder[i] = tab[i];
                Array.Sort(holder);
                if ((i + 1)%2 == 0)
                {
                    Console.WriteLine((holder[i / 2] + holder[(i / 2) + 1]) / 2);
                }
                if ((i+1)%2 != 0)
                {
                    Console.WriteLine(holder[i / 2]);
                }
            }
        }
    }
}