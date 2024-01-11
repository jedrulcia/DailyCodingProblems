class Program
{
    static void Main()
    {
        Node root = new Node(10);
        root.left = new Node(5);
        root.right = new Node(15);
        root.right.left = new Node(11);
        root.right.right = new Node(15);
        int n = 20;
        SumOfN(root, root.value, n);
    }
    static void SumOfN(Node root, int value, int n)
    {
        if (root.left != null)
        {
            if (root.left.value + value == n)
            {
                Console.WriteLine($"{root.left.value}, {value}");
                System.Environment.Exit(0);
            }
            SumOfN(root.left, root.left.value, n);
            SumOfN(root.left, value, n);
        }
        if(root.right != null)
        {
            if (root.right.value + value == n)
            {
                Console.WriteLine($"{root.right.value}, {value}");
                System.Environment.Exit(0);
            }
            SumOfN(root.right, root.right.value, n);
            SumOfN(root.right, value, n);
        }
        if(root.right != null && root.left != null)
        {
            SumOfN(root.right, root.left.value, n);
            SumOfN(root.left, root.right.value, n);
        }
    }
}
class Node
{
    public int value;
    public Node left;
    public Node right;
    public Node(int value)
    {
        this.value = value;
        this.left = null;
        this.right = null;
    }
}