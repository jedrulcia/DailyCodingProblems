namespace CodingProblem10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] tab = new string[,] { {"SFO", "HKO" }, {"YYZ", "SFO" }, { "YUL", "YYZ" }, { "HKO", "ORD" } };
            string startingAirport = "YUL";
            string[] convertedTab = ConvertingTab(tab);
            string[] itinerary = Itinerary(convertedTab, startingAirport);
            Array.ForEach(itinerary, Console.WriteLine);
        }
        static string[] ConvertingTab(string[,] tab)
        {
            string[] convertedTab = new string[tab.Length / 2];
            for (int i = 0; i < tab.Length/2; i++)
            {
                convertedTab[i] = tab[i, 0] + tab[i, 1];
            }
            Array.Sort(convertedTab);
            return convertedTab;
        }
        static string[] Itinerary(string[] tab, string startingAirport)
        {
            string[] itinerary = {startingAirport};
            for (int i = 0, x = 0; i < tab.Length; i++)
            {
                string holder1 = tab[i].Substring(0, tab[i].Length / 2);
                string holder2 = tab[i].Substring((tab[i].Length / 2), tab[i].Length/2);
                if (holder1 == itinerary[x])
                {
                    Array.Resize(ref itinerary, itinerary.Length + 1);
                    x++;
                    itinerary[x] = holder2;
                    tab[i] = "Used";
                    i = -1;
                }
            }
            if (itinerary.Length -1 != tab.Length)
            {
                return itinerary = new string[0];
            }
            return itinerary;
        }
    }
}