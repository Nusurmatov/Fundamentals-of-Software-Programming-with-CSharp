
public class BinarySearchTree<T> where T : IComparable<T>
{
    internal class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>> where T : IComparable<T>
    {
        internal T Value { get; set; }

        internal BinaryTreeNode<T>? Parent { get; set; }

        internal BinaryTreeNode<T>? LeftChild { get; set; }

        internal BinaryTreeNode<T>? RightChild { get; set; }

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

    private BinaryTreeNode<T>? root;

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
                node.LeftChild = this.Insert(value, node, node.LeftChild);
            }
            else if (compareTo > 0)
            {
                node.RightChild = this.Insert(value, node, node.RightChild);
            }
        }

        return node;
    }

    public bool Contains(T value)
    {
        bool found = this.Find(value) != null;
        
        return found;
    }

    private BinaryTreeNode<T>? Find(T value)
    {
        BinaryTreeNode<T>? node = this.root;
        while (node != null)
        {
           int compareTo = value.CompareTo(node.Value);
           if (compareTo < 0)
           {
                node = node.LeftChild;
           }
           else if (compareTo > 0)
           {
                node = node.RightChild;
           }
           else
           {
            break;
           }
        }

        return node;
    }

    public void Remove(T value)
    {
        BinaryTreeNode<T>? nodeToBeDeleted = this.Find(value);

        if (nodeToBeDeleted != null)
        {
            this.Remove(nodeToBeDeleted);
        }
    }

    private void Remove(BinaryTreeNode<T> node)
    {
        // Case 3: If the node has two children
        // if we get here at the end the node 
        // will be with at most one child
        if (node.LeftChild != null && node.RightChild != null)
        {
            var replacement = node.RightChild;
            while (replacement.LeftChild != null)
            {
                replacement = replacement.LeftChild;
            }
            
            node.Value = replacement.Value;
            node = replacement;
        }

        // Case 1 and 2: If the node has at most one child
        var theChild = node.LeftChild != null ? node.LeftChild : node.RightChild;

        // if the element to be deleted has one child
        if (theChild != null)
        {
            theChild.Parent = node.Parent;

            // Handle the case when the element is the root
            if (node.Parent == null)
            {
                root = theChild;
            }
            else
            {
                // Replace the element with its child sub-tree
                if (node.Parent.LeftChild == node)
                {
                    node.Parent.LeftChild = theChild;                    
                }                
                else
                {
                    node.Parent.RightChild = theChild;
                }
            }
        }
        else
        {
            // Handle the case when the element is the root
            if (node.Parent == null)
            {
                root = null;
            } 
            else
            {
                // Remove the element - it is a leaf
                if (node.Parent.LeftChild == node)
                {
                    node.Parent.LeftChild = null;
                }
                else
                {
                    node.Parent.RightChild = null;
                }
            }
        }
    }

    public void PrintTreeDFS()
    {
        PrintTreeDFS(this.root);
    }

    private void PrintTreeDFS(BinaryTreeNode<T> node)
    {
        if (node != null)
        {
            PrintTreeDFS(node.LeftChild);
            
            string output = $"{node.Value} ";
            Console.Write(output);
            OutputUtil.LogToFile(output, isAppend: true, isOneLine: true);
            
            PrintTreeDFS(node.RightChild);
        }
    }
}