class Program
{
    static void Main()
    {
        BinaryTree root = new BinaryTree(10);
        root.left = new BinaryTree(5);
        root.left.right = new BinaryTree(2);
        root.right = new BinaryTree(5);
        root.right.right = new BinaryTree(1);
        root.right.right.left = new BinaryTree(-1);

        int sum = int.MaxValue;
        BinaryTree.MinimumPathSum(root, ref sum, 0);

        Console.WriteLine(sum);

    }
}
class BinaryTree
{
    public int value;
    public BinaryTree left;
    public BinaryTree right;

    public BinaryTree (int value)
    {
        this.value = value;
        this.left = null;
        this.right = null;
    }

    public static void MinimumPathSum(BinaryTree root, ref int sum, int currentSum)
    {
        currentSum += root.value;
        if (root.left != null)
        {
            BinaryTree.MinimumPathSum(root.left, ref sum, currentSum);
        }
        if (root.right != null)
        {
            BinaryTree.MinimumPathSum(root.right, ref sum, currentSum);
        }
        if (root.left == null && root.right == null)
        {
            if (currentSum < sum)
            {
                sum = currentSum;
            }
        }
    }
}