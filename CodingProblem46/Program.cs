class Program
{
    static void Main()
    {
        SingleLinkedList list = new SingleLinkedList(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Display();
        Console.WriteLine();

        list.Swap();
        list.Display();
    }
}
class SingleLinkedList
{
    public int value;
    public int index;
    public SingleLinkedList next;

    public SingleLinkedList(int value)
    {
        this.value = value;
        this.index = 0;
        this.next = null;
    }
    public void Add(int value)
    {
        if (next == null)
        {
            next = new SingleLinkedList(value);
            next.index = index + 1;
        }
        else next.Add(value);
    }
    public void Display()
    {
        Console.Write(value);
        if (next != null) next.Display();
    }
    public void Swap()
    {
        if(next != null && index % 2 == 0)
        {
            int holder = value;
            value = next.value;
            next.value = holder;
        }
        if(next != null) next.Swap();
    }
}