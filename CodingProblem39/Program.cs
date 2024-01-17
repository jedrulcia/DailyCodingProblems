class Program
{
    static void Main()
    {
        string[] tab = Arrow(3);
        Array.ForEach(tab, Console.WriteLine);
    }

    static string[] Arrow(int n)
    {
        int length = n * 2;
        if (n % 2 != 0) length--;
        
        string[] arrowsArray = new string[length];
        string arrows = "";

        for (int i = 0, j = arrowsArray.Length - 1; i < n; i++, j--)
        {
            arrows += ">";
            arrowsArray[i] = arrows;
            arrowsArray[j] = arrows;
        }
        return arrowsArray;
    }
}