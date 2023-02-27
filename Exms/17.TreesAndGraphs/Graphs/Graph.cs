public class Graph
{
    private List<int>[] childNodes;

    public Graph(int size)
    {
        this.childNodes = new List<int>[size];
        for (int i = 0; i < size; i++)
        {
            // Assigning an empty list of adjacents for each vertex
            this.childNodes[i] = new List<int>();
        }
    }

    public Graph(List<int>[] childNodes)
    {
        this.childNodes = childNodes;
    }

    public int Size => this.childNodes.Length;

    public void AddEdge(int u, int v) => childNodes[u].Add(v);

    public void RemoveEdge(int u, int v) => childNodes[u].Remove(v);

    public bool HasEdge(int u, int v) => childNodes[u].Contains(v);

    public IList<int> GetSuccessors(int v) => childNodes[v];
}