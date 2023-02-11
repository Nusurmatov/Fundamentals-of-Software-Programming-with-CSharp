public class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>> where T : IComparable<T>
{
    public T Value { get; private set; }

    public BinaryTreeNode<T>? Parent { get; private set; }

    public BinaryTreeNode<T>? LeftChild { get; private set; }


    public BinaryTreeNode<T>? RightChild { get; private set; }


    public BinaryTreeNode(T value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("Cannot insert null value!");
        }

        this.Value = value;
        this.Parent = null;
        this.LeftChild = null;
        this.RightChild = null;
    }

    public override string ToString() => this.Value.ToString();

    public override int GetHashCode() => this.Value.GetHashCode();

    public override bool Equals(object? obj)
    {
        var other = (BinaryTreeNode<T>) obj;
        return this.CompareTo(other) == 0;
    }

    public int CompareTo(BinaryTreeNode<T>? other)
    {
        return this.Value.CompareTo(other.Value);
    }
}