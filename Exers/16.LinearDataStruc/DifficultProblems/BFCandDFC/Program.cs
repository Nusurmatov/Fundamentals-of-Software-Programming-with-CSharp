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
int[,] labyrinth = {  {0,  0,  0, -1,  0, -1},
                      {0, -1,  0, -1,  0, -1},               
                      {0, -2, -1,  0, -1,  0},               
                      {0, -1,  0,  0,  0,  0},               
                      {0,  0,  0, -1, -1,  0},               
                      {0,  0,  0, -1,  0, -1},               
 };
bool[,] visited = { {false, false, false, false, false, false},
                    {false, false, false, false, false, false},
                    {false, false, false, false, false, false},
                    {false, false, false, false, false, false},
                    {false, false, false, false, false, false},
                    {false, false, false, false, false, false}
};

Console.Clear();
Console.WriteLine("Labyrinth: ");
labyrinth.PrintMatrix(0, labyrinth.GetLength(0), 0, labyrinth.GetLength(1));

CalculateMinDistanceBetweenEachCellAndStartPosition(labyrinth);
Console.WriteLine("\nMinimal Distance from the start position (2, 1) to each cell:");
labyrinth.PrintMatrix(0, labyrinth.GetLength(0), 0, labyrinth.GetLength(1), isLabyrinthProblemDone: true);

void CalculateMinDistanceBetweenEachCellAndStartPosition(int[,] matrix, int startPositionRow = 2, int startPositionColumn = 1)
{
    Queue<(int row, int column, int distance)> positions = new Queue<(int, int, int)>();
    int distance = 0;
    positions.Enqueue((startPositionRow, startPositionColumn, distance));
    int row, column;

    while (positions.Any())
    {
        (row, column, distance) = positions.Dequeue();

        if (visited[row, column])
        {
            continue;
        }
        else
        {
            visited[row, column] = true;
        }

        if (row + 1 < 6)  // check bottom
        {
            if (labyrinth[row + 1, column] == 0)  
            {
                labyrinth[row + 1, column] = distance + 1;
                positions.Enqueue((row + 1, column, distance + 1));
            }
        }
        if (row - 1 >= 0)  // check top
        {
            if (labyrinth[row - 1, column] == 0)
            {
                labyrinth[row - 1, column] = distance + 1;
                positions.Enqueue((row - 1, column, distance + 1));
            }
        }
        if (column - 1 >= 0)  // check left
        {
            if (labyrinth[row, column - 1] == 0)
            {
                labyrinth[row, column - 1] = distance + 1;
                positions.Enqueue((row, column - 1, distance + 1));
            }
        }
        if (column + 1 < 6)  // check right
        {
            if (labyrinth[row, column + 1] == 0)
            {
                labyrinth[row, column + 1] = distance + 1;
                positions.Enqueue((row, column + 1, distance + 1));
            }            
        }

    }
}

/* Output:
Labyrinth:
 ___                    ___
|                          |
|   0   0   0   x   0   x  |
|   0   x   0   x   0   x  |
|   0   *   x   0   x   0  |
|   0   x   0   0   0   0  |
|   0   0   0   x   x   0  |
|   0   0   0   x   0   x  |
|                          |
 ‾‾‾                    ‾‾‾

Minimal Distance from the start position (2, 1) to each cell:
 ___                    ___
|                          |
|   3   4   5   x   u   x  |
|   2   x   6   x   u   x  |
|   1   *   x   8   x  10  |
|   2   x   6   7   8   9  |
|   3   4   5   x   x  10  |
|   4   5   6   x   u   x  |
|                          |
 ‾‾‾                    ‾‾‾ 
*/