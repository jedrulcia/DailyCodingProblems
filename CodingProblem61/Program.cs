using System.ComponentModel.Design.Serialization;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        BinaryTree root = new BinaryTree(1);
        root.left = new BinaryTree(2);
        root.right = new BinaryTree(3);
        root.left.left = new BinaryTree(4);
        root.left.right = new BinaryTree(5);
        root.right.left = new BinaryTree(6);
        root.right.right = new BinaryTree(7);

        int levelCounter = 0;
        root.CountElementsOfTree(root, ref levelCounter);

        double numberOfNodes = Math.Pow(2, levelCounter) - 1;

        Console.WriteLine(numberOfNodes);
    }

}
class BinaryTree
{
    public int value;
    public BinaryTree left;
    public BinaryTree right;

    public BinaryTree(int value)
    {
        this.value = value;
        this.left = null;
        this.right = null;
    }
    public void CountElementsOfTree(BinaryTree node, ref int levelCounter)
    {
        levelCounter++;
        if (node.left != null) CountElementsOfTree(node.left, ref levelCounter);
    }
}