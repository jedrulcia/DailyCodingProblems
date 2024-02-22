class Program
{
    static void Main()
    {
        int[] tab = { 3, 4, 9, 6, 1 };
        int[] newTab = SmallerElementsOnTheRight(tab);
        Array.ForEach(newTab, Console.WriteLine);
    }
    static int[] SmallerElementsOnTheRight(int[] tab)
    {
        int[] newTab = new int[tab.Length];
        for (int i = 0; i < tab.Length; i++) newTab[i] = HowManySmallerElements(tab, i);
        return newTab;
    }
    static int HowManySmallerElements(int[] tab, int index)
    {
        int count = 0;
        if (index > tab.Length) return 0;
        for (int i = index + 1; i < tab.Length; i++) if (tab[index] > tab[i]) count++;
        return count;
    }
}