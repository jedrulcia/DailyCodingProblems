class Program
{
    static void Main()
    {
        SingleLinkedList<int> list = new SingleLinkedList<int>(0);
        int[] tab = { 5, 4, 1, 9, 1, 2, 3, 4 };
        for (int i = 0; i < tab.Length; i++)
        {
            list.Add(tab[i]);
        }
        Console.WriteLine(list.HasNext(0));
        Console.WriteLine(list.Next(0));
        Console.WriteLine(list.Peek(0));
    }
}
class SingleLinkedList<T>
{
    public T value;
    public SingleLinkedList<T> next;
    public int currentIndex;

    public SingleLinkedList(T value)
    {
        this.value = value;
        this.next = null;
        this.currentIndex = 0;
    }
    public void Add(T value)
    {
        if (next == null)
        {
            next = new SingleLinkedList<T>(value);
            next.currentIndex = currentIndex + 1;
        }
        else
        {
            next.Add(value);
        }
    }
    public SingleLinkedList<T> Next(int index)
    {
        if (index == currentIndex) return next; 
        else if (next.HasNext(index) == true) return next.Next(index);
        else return null;
    }
    public bool HasNext(int index)
    {
        if(index == currentIndex && next != null) return true;
        else if (index == currentIndex && next == null) return false;
        else return next.HasNext(index);
    }
    public T Peek(int index)
    {
        if (index == currentIndex &&  next != null) return next.value;
        else if (index != currentIndex && next != null) return next.Peek(index);
        else return SignalNoValue();
    }
    private T SignalNoValue()
    {
        throw new InvalidOperationException("No value available.");
    }
}
