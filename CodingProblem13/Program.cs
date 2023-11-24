namespace CodingProblem13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 19;

            int perfectNumber = PerfectNumber(n);

            if (perfectNumber == 0)
            {
                Console.WriteLine("Given number can't be modified into perfect number");
            }
            else
            {
                Console.WriteLine(perfectNumber);
            }
        }
        static int PerfectNumber (int n)
        {
            string nString = Convert.ToString(n);
            int sum = 0;
            int perfectNumber = 0;
            for (int i = 0; i < nString.Length; i++)
            {
                sum = sum + Convert.ToInt32(nString.Substring(i, 1));
            }
            int holder = 10 - sum;
            if (holder >= 0)
            {
                nString = nString + holder;
                perfectNumber = Convert.ToInt32(nString);
            }
            return perfectNumber;
        }
    }
}