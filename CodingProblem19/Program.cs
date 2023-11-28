public class Node
{
    public char Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
    public int Depth { get; set; }
    public Node(char value)
    {
        this.Value = value;     
        this.Left = null;      
        this.Right = null;
        this.Depth = 0;
    }
}
class Program
{
    static void Main()
    {
        Node a = new Node('a');
        Node b = new Node('b');
        Node c = new Node('c');
        Node d = new Node('d');

        a.Left = b;
        a.Right = c;
        b.Left = d;

        Node[] tab = new Node[0];
        DeepestValues(a, 0, ref tab);

        FindDeepestValue(tab);
    }
    static void DeepestValues(Node root, int depth, ref Node[] tab)         // This method searches for the deepest nodes, and then writes them into the array.
    {
        depth++;
        if (root.Left == null && root.Right == null)
        {
            root.Depth = depth;
            int x = tab.Length;
            Array.Resize(ref tab, x + 1);
            tab[x] = root;
            return;
        }
        else if (root.Left == null && root.Right != null)
        {
            DeepestValues(root.Right, depth, ref tab);
        }
        else if (root.Right == null && root.Left != null)
        {
            DeepestValues(root.Left, depth, ref tab);
        }
        else
        {
            DeepestValues(root.Left, depth, ref tab);
            DeepestValues(root.Right, depth, ref tab);
        }
    }
    static void FindDeepestValue(Node[] tab)                                // This method searches for the nodes with the highest 'int depth' value, that were written into the array
    {
        int depth = -1;
        char value = ' ';
        for (int i = 0; i < tab.Length; i++)
        {
            if (tab[i].Depth > depth)
            {
                value = tab[i].Value;
                depth = tab[i].Depth;
            }
        }
        Console.WriteLine($"One of the deepest values of the binary tree is {value}.");
    }
}