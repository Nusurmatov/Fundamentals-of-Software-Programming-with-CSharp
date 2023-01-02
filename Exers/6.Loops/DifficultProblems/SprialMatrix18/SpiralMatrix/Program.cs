/* (Difficult Problems) Ex18 - Problem Statement:
* Write a program that for a given number n, outputs a matrix in the form of a spiral:
             ___________                          ___
N = 3  -->  | 1 | 2 | 3 |            N = 1  -->  | 1 | 
            | 8 | 9 | 4 |                         ‾‾‾
            | 7 | 6 | 5 |
             ‾‾‾‾‾‾‾‾‾‾‾
              __________________                  _______
N = 4  -->   | 1  | 2  | 3  | 4 |    N = 2  -->  | 1 | 2 |
             | 12 | 13 | 14 | 5 |                | 4 | 3 |   
             | 11 | 16 | 15 | 6 |                 ‾‾‾‾‾‾‾
             | 10 | 9  | 8  | 7 |
              ‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("N = ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[n, n];

        FillMatrix(matrix, n);

        PrintMatrix(matrix, n);
      
    }
    private static void FillMatrix(int[,] matrix, int n)
        {
            int positionX = n / 2; // The middle of the matrix
            int positionY = n % 2 == 0 ? n / 2 - 1 : n / 2;
            int direction = 0; // The initial direction is "down"
            int stepsCount = 1; // Perform 1 step in current direction
            int stepPosition = 0; // 0 steps already performed
            int stepChange = 0; // Steps count changes after 2 steps
            for (int i = 0; i < n * n; i++)
            {
                // Fill the current cell with the current value
                matrix[positionY, positionX] = i;
                // Check for direction / step changes
                if (stepPosition < stepsCount)
                {
                    stepPosition++;
                }
                else
                {
                    stepPosition = 1;
                    if (stepChange == 1)
                    {
                        stepsCount++;
                    }
                    stepChange = (stepChange + 1) % 2;
                    direction = (direction + 1) % 4;
                }
                // Move to the next cell in the current direction
                switch (direction)
                {
                    case 0:
                        positionY++;
                        break;
                    case 1:
                        positionX--;
                        break;
                    case 2:
                        positionY--;
                        break;
                    case 3:
                        positionX++;
                        break;
                }
            }
        }
    private static void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,5}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

}

/* Input/Output:
N = 7
   36   37   38   39   40   41   42
   35   16   17   18   19   20   43
   34   15    4    5    6   21   44
   33   14    3    0    7   22   45
   32   13    2    1    8   23   46
   31   12   11   10    9   24   47
   30   29   28   27   26   25   48
*/
