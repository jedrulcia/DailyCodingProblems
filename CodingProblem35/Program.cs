using System.ComponentModel.DataAnnotations;
using System.Reflection;

class Program
{
    static void Main()
    {
        int[] tab = { 9, 9 };
        int[] tab2 = { 5, 2 };

        SingleLinkedList<int> list = Sollution(tab, tab2);
    }

    static SingleLinkedList<int> Sollution(int[] tab, int[] tab2)
    {
        SingleLinkedList<int> list = CreateList(tab);
        string text = list.CovertListToString(tab.Length - 1, "");

        SingleLinkedList<int> list2 = CreateList(tab2);
        string text2 = list2.CovertListToString(tab2.Length - 1, "");

        int[] tab3 = SumOfLists(text, text2);

        SingleLinkedList<int> list3 = CreateList(tab3);
        string text3 = list3.CovertListToString(tab3.Length - 1, "");

        Console.WriteLine(text3);
        return list3;
    }
    static SingleLinkedList<int> CreateList(int[] tab)
    {
        SingleLinkedList<int> list = new SingleLinkedList<int>(tab[0]);
        for (int i = 1; i < tab.Length; i++)
        {
            list.Add(tab[i]);
        }
        return list;
    }
    static int[] SumOfLists(string text, string text2)
    {
        int sum = Convert.ToInt32(text) + Convert.ToInt32(text2);
        int x = 0;
        string holder = Convert.ToString(sum);
        int length = holder.Length;
        int[] tab = new int[length];
        for(int i = length; i > 0; i--)
        {
            tab[x] = Convert.ToInt32(holder.Substring(i - 1, 1));
            x++;
        }
        return tab;
    }
}

public class SingleLinkedList<T>
{
    public int value;
    public SingleLinkedList<int> next;
    public SingleLinkedList(int value)
    {
        this.value = value;
        this.next = null;
    }

    public void Add(int value)
    {
        if (next == null)
        {
            next = new SingleLinkedList<int>(value);
        }
        else
        {
            next.Add(value);
        }
    }
    public string CovertListToString(int index, string text)
    {
        if (index == 0)
        {
            string holder = text;
            text = Convert.ToString(value);
            text += holder;
            return text;
        }
        else if (next != null)
        {
            string holder = text;
            text = Convert.ToString(value);
            text += holder;
            return next.CovertListToString(index - 1, text);
        }
        else
        {
            throw new IndexOutOfRangeException();
        }
    }
}