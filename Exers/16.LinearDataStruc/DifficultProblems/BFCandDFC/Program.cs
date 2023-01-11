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
char[,] labyrinth = { {'0', '0', '0', 'x', '0', 'x'},
                      {'0', 'x', '0', 'x', '0', 'x'},               
                      {'0', '*', 'x', '0', 'x', '0'},               
                      {'0', 'x', '0', '0', '0', '0'},               
                      {'0', '0', '0', 'x', 'x', '0'},               
                      {'0', '0', '0', 'x', '0', 'x'},               
 };
int startPositionRow = 1;
int startPositionColumn = 2;
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
Console.WriteLine("\n\nMinimal Distance from the start position (1, 2) to each cell:");
labyrinth.PrintMatrix(0, labyrinth.GetLength(0), 0, labyrinth.GetLength(1));

void CalculateMinDistanceBetweenEachCellAndStartPosition(char[,] matrix, int startPositionRow = 1, int startPositionColumn = 2)
{
    Queue<(int, int)> positions = new Queue<(int, int)>();
    positions.Enqueue((startPositionRow, startPositionColumn));
    char distanceInChar = '1';
    int distanceInNumber = 1;
    int row, column;

    while (positions.Any())
    {
        (row, column) = positions.Dequeue();
        Console.Write("({0}, {1})  ", row, column);
        if (visited[row, column])
        {
            continue;
        }
        else
        {
            visited[row, column] = true;
        }

        if (row + 1 < 6)  // check right
        {
            if (labyrinth[row + 1, column] == '0')  
            {
                labyrinth[row + 1, column] = distanceInChar;
                positions.Enqueue((row + 1, column));
            }
        }
        if (row - 1 >= 0)  // check left
        {
            if (labyrinth[row - 1, column] == '0')
            {
                labyrinth[row - 1, column] = distanceInChar;
                positions.Enqueue((row - 1, column));
            }
        }
        if (column - 1 >= 0)  // check top
        {
            if (labyrinth[row, column - 1] == '0')
            {
                labyrinth[row, column - 1] = distanceInChar;
                positions.Enqueue((row, column - 1));
            }
        }
        if (column + 1 < 6)  // check bottom
        {
            if (labyrinth[row, column + 1] == '0')
            {
                labyrinth[row, column + 1] = distanceInChar;
                positions.Enqueue((row, column + 1));
            }            
        }

        distanceInNumber++;
        distanceInChar = Convert.ToChar(distanceInNumber);
    }
}

/* Output:

*/