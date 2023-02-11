// In-order: (left-root-right), Pre-order: (root-left-right), Post-order: (left-right-root)
public class BinaryTree<T>
{
    public T Value { get; set; }

    public BinaryTree<T>? LeftChild { get; private set; }

    public BinaryTree<T>? RightChild { get; private set; }

    public BinaryTree(T value, BinaryTree<T>? leftChild = null, BinaryTree<T>? rightChild = null)
    {
        this.Value = value;
        this.LeftChild = leftChild;
        this.RightChild = rightChild;
    }

    public void PrintInOrder()
    {
        //1. Visit the left child
        if (this.LeftChild != null)
        {
            this.LeftChild.PrintInOrder();
        }

        //2. Visit the root of this sub-tree
        var output = $"{this.Value} ";
        Console.Write(output);
        OutputUtil.LogToFile(output, isAppend: true);

        //3. Visit the right child
        if (this.RightChild != null)
        {
            this.RightChild.PrintInOrder();
        }
    }
}