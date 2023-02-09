public class TreeNode<T>
{
    private bool hasParent;

    private List<TreeNode<T>> children;

    public T Value { get; private set; }

    public int ChildrenCount => children.Count;

    public TreeNode(T value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("Cannot insert null value!");
        }

        this.children = new List<TreeNode<T>>();
        this.Value = value;
    }

    public void AddChild(TreeNode<T> child)
    {
        if (child == null)
        {
            throw new ArgumentNullException("Cannot insert null value!");
        }

        if (child.hasParent)
        {
            throw new ArgumentException("The node already has a parent!");
        }

        child.hasParent = true;
        this.children.Add(child);
    }

    public TreeNode<T> GetChild(int index) => this.children[index];
}