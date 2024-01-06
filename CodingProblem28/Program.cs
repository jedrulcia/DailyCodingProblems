class Program
{
    static void Main()
    {
        Node root = new Node(1);
        root.left = new Node(2);
        root.right = new Node(3);
        root.right.left = new Node(4);
        root.right.right = new Node(5);

        int[] path = new int[0];
        FindAllPaths(path, root);
    }
    static void FindAllPaths(int[] path, Node root)
    {
        Array.Resize(ref path, path.Length + 1);
        path[path.Length - 1] = root.value;

        if (root.left != null)
        {
            FindAllPaths(path, root.left);
        }
        if (root.right != null)
        {
            FindAllPaths(path, root.right);
        }
        if (root.right == null && root.left == null)
        {
            foreach (int index in path)
            {
                Console.Write(index + " ");
            }
            Console.WriteLine();
        }
    }

}

class Node
{
    public int value;
    public Node right;
    public Node left;
    public Node(int value)
    {
        this.value = value;
        this.right = null;
        this.left = null;
    }
}