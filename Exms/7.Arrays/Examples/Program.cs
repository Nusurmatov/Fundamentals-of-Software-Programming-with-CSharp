// Exm4 - Arrays of Arrays (Jagged Arrays):  

// Declaration:
int[][] jaggedArray;
jaggedArray = new int[2][];
jaggedArray[0] = new int[5];
jaggedArray[1] = new int[3];

// Assigning at the time of Declaration:
int[][] myJaggedArray = {
    new int[] {5, 7, 2},
    new int[] {10, 20, 40},
    new int[] {3, 25}
};

Console.WriteLine(myJaggedArray);

// Exm5 - Pascal's Triangle:
const int HEIGHT = 12;

// Allocate the array in a triangle form
long[][] triangle = new long[HEIGHT + 1][];

for (int row = 0; row < HEIGHT; row++)
{
    triangle[row] = new long[row + 1];
}

// Calculate the Pascal's triangle
triangle[0][0] = 1;
for (int row = 0; row < HEIGHT - 1; row++)
{
    for (int col = 0; col <= row; col++)
    {
        triangle[row + 1][col] += triangle[row][col];
        triangle[row + 1][col + 1] += triangle[row][col];
    }
}

// Print the Pascal's triangle
for (int row = 0; row < HEIGHT; row++)
{
    Console.Write("".PadLeft((HEIGHT - row) * 2));
    for (int col = 0; col <= row; col++)
    {
        Console.Write("{0,3} ", triangle[row][col]);
    }
        Console.WriteLine();
}


/*  Input/Output:
System.Int32[][]
                          1
                        1   1
                      1   2   1
                    1   3   3   1
                  1   4   6   4   1
                1   5  10  10   5   1
              1   6  15  20  15   6   1
            1   7  21  35  35  21   7   1
          1   8  28  56  70  56  28   8   1
        1   9  36  84 126 126  84  36   9   1
      1  10  45 120 210 252 210 120  45  10   1
    1  11  55 165 330 462 462 330 165  55  11   1
 */