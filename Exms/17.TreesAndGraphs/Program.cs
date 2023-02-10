Console.Clear();
var undone = true;
var output = new System.Text.StringBuilder();
var input = new ConsoleKeyInfo();

output.AppendLine("Enter 1 -> TreeExample");
output.AppendLine("      2 -> TraverseExample");
//output.AppendLine("      3 -> ");
//output.AppendLine("      4 -> ");
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
    var path = @"E:\KhN\IT\.NET Development\Fundamentals-of-Software-Programming-with-CSharp";
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