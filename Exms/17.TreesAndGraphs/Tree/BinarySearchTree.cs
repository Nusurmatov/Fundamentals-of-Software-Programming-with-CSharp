
public class BinarySearchTree<T> where T : IComparable<T>
{
    internal class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>> where T : IComparable<T>
    {
        internal T Value { get; private set; }

        internal BinaryTreeNode<T> Parent { get; set; }

        internal BinaryTreeNode<T> LeftChild { get; private set; }

        internal BinaryTreeNode<T> RightChild { get; private set; }

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

        public int CompareTo(BinaryTreeNode<T>? other) => this.Value.CompareTo(other.Value);
    }

    private BinaryTreeNode<T> root;

    public BinarySearchTree() => this.root = null;

    public void Insert(T value) => this.root = this.Insert(value, null, this.root);

    private BinaryTreeNode<T> Insert(T value, BinaryTreeNode<T>? parentnode, BinaryTreeNode<T>? node)
    {
        if (node == null)
        {
            node = new BinaryTreeNode<T>(value);
            node.Parent = parentnode;
        }
        else
        {
            int compareTo = value.CompareTo(node.Value);

            if (compareTo < 0)
            {
                this.Insert(value, node, node.LeftChild);
            }
            else if (compareTo > 0)
            {
                this.Insert(value, node, node.RightChild);
            }
        }

        return node;
    }
}