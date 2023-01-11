/* Difficult Problem, Exercise 18 - Problem Statements:
We are given a labyrinth of size N x N. Some of the cells of the labyrinth are empty (0), and others are filled (x). 
We can move from an empty cell to another empty cell, if the cells are separated by a single wall. We are given a start position (*). 
Calculate and fill the labyrinth as follows: in each empty cell put the minimal distance from the start position to this cell. 
If some cell cannot be reached, fill it with "u".
Example:
*/

DriveInfo eDrive = new DriveInfo("E");
Queue<DirectoryInfo> queueDir = new Queue<DirectoryInfo>();
Stack<DirectoryInfo> stackDir = new Stack<DirectoryInfo>();
int numberForColor = 1;

Console.Clear();
Console.WriteLine("Which one do you want, BFC or DFC to traverse and print all the directories of hard disk?");
Console.Write("BFC - Breadth First Search, DFC - Depth First Search, enter 'b' or 'd': ");
string algorithm = Console.ReadLine() ?? "Invalid value!";
algorithm = algorithm.Trim().ToLowerInvariant();

if (algorithm == "b")
{
    PrintAllDirectoriesOfHardDiskUsingBFC();
}
else if (algorithm == "d")
{
    PrintAllDirectoriesOfHardDiskUsingDFC();
}
else
{
    Console.WriteLine(algorithm);
}

void PrintAllDirectoriesOfHardDiskUsingBFC()
{
    queueDir.Enqueue(eDrive.RootDirectory);
    Console.WriteLine(eDrive.RootDirectory);
    
    while (queueDir.Any())
    {
        var dir = queueDir.Dequeue();
        numberForColor = (numberForColor != 15) ? numberForColor + 1 : 1;
        Console.ForegroundColor = (ConsoleColor)numberForColor;
        try
        {
            foreach (var subDir in dir.GetDirectories())
            {
                queueDir.Enqueue(subDir);
                Console.WriteLine(subDir); 
            }     
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

void PrintAllDirectoriesOfHardDiskUsingDFC()
{
    stackDir.Push(eDrive.RootDirectory);
    Console.WriteLine(eDrive.RootDirectory);
    
    while (stackDir.Any())
    {
        var dir = stackDir.Pop();
        numberForColor = (numberForColor != 15) ? numberForColor + 1 : 1;
        Console.ForegroundColor = (ConsoleColor)numberForColor;
        try
        {
            foreach (var subDir in dir.GetDirectories())
            {
                stackDir.Push(subDir);
                Console.WriteLine(subDir); 
            }     
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}