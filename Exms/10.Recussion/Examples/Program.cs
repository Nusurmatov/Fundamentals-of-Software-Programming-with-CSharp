// Ex8 - Searching for Paths in a Labyrinth (Informative):

/*
char[,] lab =
{
    {' ', ' ', ' ', '*', ' ', ' ', ' '},
    {'*', '*', ' ', '*', ' ', '*', ' '},
    {' ', ' ', ' ', ' ', ' ', ' ', ' '},
    {' ', '*', '*', '*', '*', '*', ' '},
    {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
};
*/

char[,] lab =
{
    {'e'},
};

char[] exitPaths = new char[lab.GetLength(0) * lab.GetLength(1)];
int position = 0;

void FindPath(int row, int col, char direction)
{
    if ((col < 0) || (row < 0) || (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
    {
        // We are out of the labyrinth
        return;
    }

    // Check if we have found the exit
    if (lab[row, col] == 'e')
    {
        PrintExitPaths(exitPaths, 0, position);
    }

    if (lab[row, col] != ' ')
    {
        // The current cell is not free
        return;
    }

    // Append the direction to the path
    exitPaths[position] = direction;
    position++;

    // Mark the current cell as visited
    lab[row, col] = 's';
    
    // Invoke recursion to explore all possible directions
    FindPath(row, col - 1, 'L'); // left
    FindPath(row - 1, col, 'U'); // up
    FindPath(row, col + 1, 'R'); // right
    FindPath(row + 1, col, 'D'); // down
    
    // Mark back the current cell as free
    lab[row, col] = ' ';

    // Remove the last direction from the path
    position--;
}

void PrintExitPaths(char[] paths, int start, int end)
{
    Console.Write("Found an exit path: ");
    for (int i = start; i < end; i++)
    {
        Console.Write(paths[i]);
    }
    Console.WriteLine();
}

FindPath(0, 0, 'S');

/* Output:
Found an exit path: SRRDDLLDDRRRRR
Found an exit path: SRRDDRRUURRDDD
Found an exit path: SRRDDRRRRD  
*/