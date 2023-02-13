Console.Clear();
var undone = true;
var output = new System.Text.StringBuilder();
var input = new ConsoleKeyInfo();
output.AppendLine("Enter 1 -> TreeExample");
output.AppendLine("      2 -> TraverseExample");
output.AppendLine("      3 -> BinaryTreeExample");
output.AppendLine("      4 -> BinarySearchTreeExample");
output.AppendLine("      5 -> GraphExample");
output.Append("      0 -> Exit Program : ");

while (undone)
{
    Console.Write(output);
    input = Console.ReadKey();
    Console.Clear();

    switch(input.Key)
    {
        case ConsoleKey.D0: 
            undone = false; 
            break;
        case ConsoleKey.D1: 
            TreeExample(); 
            break;
        case ConsoleKey.D2:
            TraverseExample(); 
            break;
        case ConsoleKey.D3:
            BinaryTreeExample(); 
            break;
        case ConsoleKey.D4:
            BinarySearchTreeExample(); 
            break;
        case ConsoleKey.D5:
            GraphExample(); 
            break;
        default: 
            Console.WriteLine("Invalid Option!!!, please try again...\n\n"); 
            break;
    }

    Console.WriteLine();
}

void TreeExample()
{
    Tree<int> tree = 
        new Tree<int>(7,
            new Tree<int>(19,
                new Tree<int>(1),
                new Tree<int>(12),
                new Tree<int>(31)),
            new Tree<int>(21),
            new Tree<int>(14,
                new Tree<int>(23),
                new Tree<int>(6))
        );

    tree.TraverseDFS();
}

void TraverseExample()
{
    var path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
    Console.WriteLine(path);
    Console.WriteLine("Enter B -> Birdth First Search");
    Console.Write("      D -> Depth First Search : ");
    var input = Console.ReadKey();

    switch (input.Key)
    {
        case ConsoleKey.B:
            Traverser.TraverseBFS(path);   // = path.TraverseBFS();      
            break;
        case ConsoleKey.D:
            path.TraverseDFS();  // = Traverser.TraverseDFS(path);
            break;
        default:
            Console.WriteLine("Invalid Option!!!, please try again...\n\n");
            break;
    }
}

void BinaryTreeExample()
{
    // binary tree image link: http://bit.ly/3jICwTb
    var binaryTree = new BinaryTree<int>(25, 
        new BinaryTree<int>(15, 
            new BinaryTree<int>(10,
                new BinaryTree<int>(4),
                new BinaryTree<int>(12)),
            new BinaryTree<int>(22,
                new BinaryTree<int>(18),
                new BinaryTree<int>(24))),
        new BinaryTree<int>(50,
            new BinaryTree<int>(35,
                new BinaryTree<int>(31),
                new BinaryTree<int>(44)),
            new BinaryTree<int>(70,
                new BinaryTree<int>(66),
                new BinaryTree<int>(90))));

    binaryTree.PrintInOrder();
}

void BinarySearchTreeExample()
{
    var binarySearchTree = new BinarySearchTree<int>();
    binarySearchTree.Insert(19);
    binarySearchTree.Insert(13);
    binarySearchTree.Insert(35);
    binarySearchTree.Insert(23);
    binarySearchTree.Insert(13);
    binarySearchTree.Insert(17);
    binarySearchTree.Insert(7);
    binarySearchTree.Insert(11);
    binarySearchTree.Insert(5);
    binarySearchTree.Insert(18);
    binarySearchTree.Insert(22);

    binarySearchTree.PrintTreeDFS();
    Console.WriteLine("\nThe binary search tree contains 17 : {0}", binarySearchTree.Contains(17));
    Console.WriteLine("The binary search tree contains 27 : {0}\n", binarySearchTree.Contains(27));

    binarySearchTree.Remove(17);
    binarySearchTree.Remove(19);
    binarySearchTree.Remove(13);

    binarySearchTree.PrintTreeDFS();
    Console.WriteLine("\nThe binary search tree contains 17 : {0}", binarySearchTree.Contains(17));
}

void GraphExample()
{
    // the graph image:  
    Graph graph = new Graph(new List<int>[] {
        new List<int>() {4},        // successorrs of vertice 0
        new List<int>() {1, 2, 6},  // successorrs of vertice 1
        new List<int>() {1, 6},     // successorrs of vertice 2
        new List<int>() {6},        // successorrs of vertice 3
        new List<int>() {0},        // successorrs of vertice 4
        new List<int>() {},         // successorrs of vertice 5
        new List<int>() {1, 2, 3},  // successorrs of vertice 6
    });

    bool[] visited = new bool[graph.Size];

    Console.WriteLine("Connected Graph Components: ");
    for (int v = 0; v < graph.Size; v++)
    {
        if (!visited[v])
        {
            TraverseDFS(v, visited, graph);       
            Console.WriteLine(); 
        }
    }
}

void TraverseDFS(int v, bool[] visited, Graph graph)
{
    if (!visited[v])
    {
        Console.Write($"{v} ");
        visited[v] = true;
        foreach (var child in graph.GetSuccessors(v))
        {
            TraverseDFS(child, visited, graph);
        }
    }
}