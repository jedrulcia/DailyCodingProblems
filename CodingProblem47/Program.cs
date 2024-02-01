using System.ComponentModel.Design.Serialization;

class Program
{
    static void Main()
    {
        BinaryTree root = new BinaryTree(0);
        root.left = new BinaryTree(1);
        root.right = new BinaryTree(0);
        root.right.left = new BinaryTree(1);
        root.right.right = new BinaryTree(0);
        root.right.left.left = new BinaryTree(0);
        root.right.left.right = new BinaryTree(0);

        root.Display(root);

        bool shouldBeChecked = true;
        while (shouldBeChecked == true)
        {
            shouldBeChecked = false;
            root.RemoveZeroSubtrees(root, ref shouldBeChecked);
        }

        Console.WriteLine();
        root.Display(root);
    }
}
class BinaryTree
{
    public int value;
    public BinaryTree right;
    public BinaryTree left;
    public BinaryTree(int value)
    {
        this.value = value;
        this.left = null;
        this.right = null;
    }
    public void Display(BinaryTree root)
    {
        Console.Write(root.value);
        if (root.left != null) Display(root.left);
        if (root.right != null) Display(root.right);
    }
    public void RemoveZeroSubtrees(BinaryTree root, ref bool shouldBeChecked)
    {
        if (root.left != null)
        {
            if (root.left.right == null && root.left.left == null && root.left.value == 0)
            {
                root.left = null;
                shouldBeChecked = true;
            }
            else RemoveZeroSubtrees(root.left, ref shouldBeChecked);
        }
        if (root.right != null)
        {
            if (root.right.left == null && root.right.right == null && root.right.value == 0)
            {
                root.right = null;
                shouldBeChecked = true;
            }
            else RemoveZeroSubtrees(root.right, ref shouldBeChecked);
        }
    }
}