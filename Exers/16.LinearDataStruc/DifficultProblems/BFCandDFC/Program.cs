/* Difficult Problem, Exercise 18 - Problem Statements:
We are given a labyrinth of size N x N. Some of the cells of the labyrinth are empty (0), and others are filled (x). 
We can move from an empty cell to another empty cell, if the cells are separated by a single wall. We are given a start position (*). 
Calculate and fill the labyrinth as follows: in each empty cell put the minimal distance from the start position to this cell. 
If some cell cannot be reached, fill it with "u".
Example:
     _______________________            ________________________   
    | 0 | 0 | 0 | x | 0 | x |          | 3 | 4 | 5 | x | u |  x |
    | 0 | x | 0 | x | 0 | x |          | 2 | x | 6 | x | u |  x |
    | 0 | * | x | 0 | x | 0 | ________ | 1 | * | x | 8 | x | 10 |
    | 0 | x | 0 | 0 | 0 | 0 | ‾‾‾‾‾‾‾‾ | 2 | x | 6 | 7 | 8 |  9 |
    | 0 | 0 | 0 | x | x | 0 |          | 3 | 4 | 5 | x | x | 10 |
    | 0 | 0 | 0 | x | 0 | x |          | 4 | 5 | 6 | x | u |  x |
     ‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾            ‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾
*/

// x = -1,  * = -2
int[,] labyrinth = { {0,  0,  0, -1,  0, -1},
                     {0, -1,  0, -1,  0, -1},               
                     {0, -2, -1,  0, -1,  0},               
                     {0, -1,  0,  0,  0,  0},               
                     {0,  0,  0, -1, -1,  0},               
                     {0,  0,  0, -1,  0, -1},               
 };
int startPositionRow = 1;
int startPositionColumn = 2;

Console.Clear();
Console.WriteLine("Labyrinth: ");
labyrinth.PrintMatrix(0, labyrinth.GetLength(0), 0, labyrinth.GetLength(1));

CalculateMinDistanceBetweenEachCellAndStartPosition(labyrinth);
Console.WriteLine("Minimal Distance from the start position (1, 2) to each cell:");
labyrinth.PrintMatrix(0, labyrinth.GetLength(0), 0, labyrinth.GetLength(1));

void CalculateMinDistanceBetweenEachCellAndStartPosition(int[,] matrix, int startPositionRow = 1, int startPositionColumn = 2)
{
    Queue<(int, int)> positions = new Queue<(int, int)>();
    positions.Enqueue((startPositionRow, startPositionColumn));
}

/* Output:

*/