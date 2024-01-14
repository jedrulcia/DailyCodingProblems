class Program
{
    static void Main(string[] args)
    {
        int n = 4;
        Hanoi(n);
    }
    static void Hanoi(int n)
    {
        int moves = Convert.ToInt32(Math.Pow(2, n) - 1);
        int[] tab0 = CreatingTab(n);
        int[] tab1 = new int[0];
        int[] tab2 = new int[0];
        if (n % 2 == 0)
        {
            for (int move = 1; move <= moves; move++)
            {
                if (move % 3 == 0) MovingTheDisk(ref tab1, ref tab2, '1', '2', move);
                else if (move % 3 == 1) MovingTheDisk(ref tab0, ref tab1, '0', '1', move);
                else MovingTheDisk(ref tab0, ref tab2, '0', '2', move);
            }
        }
        else
        {
            for (int move = 1; move <= moves; move++)
            {
                if (move % 3 == 0) MovingTheDisk(ref tab1, ref tab2, '1', '2', move);
                else if (move % 3 == 1) MovingTheDisk(ref tab0, ref tab2, '0', '2', move);
                else MovingTheDisk(ref tab0, ref tab1, '0', '1', move);
            }
        }
    }
    static (int[], int[]) MovingTheDisk(ref int[] tabX, ref int[] tabY, char stackX, char stackY, int move)
    {
        int n = 0;
        if (tabY.Length == 0 || (tabX.Length != 0 && tabX[tabX.Length - 1] < tabY[tabY.Length - 1]))
        {
            Console.WriteLine(move + ": Move the disk from stack " + stackX + " to stack " + stackY);
            Array.Resize<int>(ref tabY, tabY.Length + 1);
            tabY[tabY.Length - 1] = tabX[tabX.Length - 1];
            Array.Resize<int>(ref tabX, tabX.Length - 1);
        }
        else
        {
            MovingTheDisk(ref tabY, ref tabX, stackY, stackX, move);
            n++;
        }
        if (n == 0) return (tabX, tabY);
        return (tabY, tabX);
    }
    static int[] CreatingTab(int n)
    {
        int[] tab0 = new int[n];
        for (int x = 0; n > 0; x++, n--) tab0[x] = n;
        return tab0;
    }
}