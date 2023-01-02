/* (Medium Problems) Ex10 - Problem Statement:
Write a program that reads from the console a positive integer number
N (N < 20) and prints a matrix of numbers as on the figures below:
             _____
N = 3  -->  |1|2|3|    
            |2|3|4|
            |3|4|5|
             ‾‾‾‾‾
             _______
N = 4  -->  |1|2|3|4|
            |2|3|4|5|
            |3|4|5|6|
            |4|5|6|7|
             ‾‾‾‾‾‾‾
*/

Console.OutputEncoding = System.Text.Encoding.Unicode;  // so that '‾' can be printed.

Console.Write("Enter a positive integer: ");
int n = Convert.ToInt32(Console.ReadLine());

int padding = (n > 9) ? 13 : 12;
Console.WriteLine("".PadRight(5*n-1, '_').PadLeft(5*n+padding));
Console.Write($"N = {n}  -->  ");
for (int i = 1; i <= n; i++)
{
    if (i != 1)
    {
        Console.Write("".PadRight(padding));
    }

    for (int j = i; j < n + i; j++)
    {
        Console.Write($"| {j}".PadRight(5));
    }
    Console.WriteLine("|");
}
Console.WriteLine("".PadRight(5*n-1, '‾').PadLeft(5*n+padding));

/* Input/Output:

*/