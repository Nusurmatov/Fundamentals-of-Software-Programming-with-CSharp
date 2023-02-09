public class Tree<T>
{
    public TreeNode<T> Root { get; private set; }

    public Tree(T value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("Cannot insert null value!");
        }

        this.Root = new TreeNode<T>(value);
    }

    public Tree(T value, params Tree<T>[] children) : this(value)
    {
        foreach (var child in children)
        {
            this.Root.AddChild(child.Root);
        }
    }

    public void TraverseDFS() => PrintDFS(this.Root, string.Empty);

    private void PrintDFS(TreeNode<T> root, string spaces)
    {
        if (root == null)
        {
            return;
        }

        string output = $"{spaces}{root.Value}";
        Console.WriteLine(output);
        OutputUtil.LogToFile(output);

        TreeNode<T>? child = null;
        for (int i = 0; i < root.ChildrenCount; i++)
        {
            child = root.GetChild(i);
            PrintDFS(child, "   ");
        }
    }
}