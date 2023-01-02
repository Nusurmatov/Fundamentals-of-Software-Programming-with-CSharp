/* Ex11 - Problem Statement:
Write a program that calculates with how many zeroes the factorial of
a given number ends. Examples:
N = 10 -> N! = 3628800 -> 2
N = 20 -> N! = 2432902008176640000 -> 4
*/

Console.Write("Enter a positive integer: ");
int n = Convert.ToInt32(Console.ReadLine());
int numOfZeroes = 0;
System.Numerics.BigInteger result = 1;

for (int i = 5, j = 1; j <= n; j++)
{
    numOfZeroes += n / i;
    if (i <= n)
    {
        i *= 5;
    }

    result *= j;
}

Console.WriteLine("N = {0} --> N! = {1} --> {2}.", n, result, numOfZeroes);

/* Input/Output
Enter a positive integer: 7
N = 7 --> N! = 5040 --> 1.
PS E:\KhN\IT\.NET Development\FofCP with C#\Exers\6.Loops\EasierProblems\EasierProblems> dotnet run
Enter a positive integer: 17
N = 17 --> N! = 355687428096000 --> 3.
PS E:\KhN\IT\.NET Development\FofCP with C#\Exers\6.Loops\EasierProblems\EasierProblems> dotnet run
Enter a positive integer: 77
N = 77 --> N! = 145183092028285869634070784086308284983740379224208358846781574688061991349156420080065207861248000000000000000000 --> 18.
*/