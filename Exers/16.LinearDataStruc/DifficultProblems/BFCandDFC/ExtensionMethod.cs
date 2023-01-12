public static class ExtensionMethod
{
    public static void PrintMatrix(this int[,] matrix, int rowStart, int rowEnd, int columnStart, int columnEnd, bool isLabyrinthProblemDone = false)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        int padding = columnEnd - columnStart;
        Console.Write(" ___");
        Console.WriteLine("___".PadLeft(padding*4 - 1));
        Console.Write("|");
        Console.WriteLine("|".PadLeft(padding*4 + 3));
        
        for (int i = rowStart; i < rowEnd; i++)
        {
            Console.Write("|");
            for (int j = columnStart; j < columnEnd; j++)
            {
                if (isLabyrinthProblemDone && matrix[i,j] == 0)
                {
                    Console.Write($"{'u',4}");
                }
                else if (matrix[i,j] == -2)
                {
                    Console.Write($"{'*',4}");
                }
                else if (matrix[i,j] == -1)
                {
                    Console.Write($"{'x',4}");
                }
                else
                {
                    Console.Write($"{matrix[i,j],4}");
                }
            }
            Console.Write("  |\n");
        
        }
        Console.Write("|");
        Console.WriteLine("|".PadLeft(padding*4 + 3));
        Console.Write(" ‾‾‾");
        Console.WriteLine("‾‾‾".PadLeft(padding*4 - 1));
    }
}