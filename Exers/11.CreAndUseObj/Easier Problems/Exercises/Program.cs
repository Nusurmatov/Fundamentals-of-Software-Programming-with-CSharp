/* (Easier) - Ex10 - Problems Statement:
You are given a sequence of positive integer numbers given as string
of numbers separated by a space. Write a program, which calculates
their sum. Example: "43 68 9 23 318" -> 461
*/

Console.Write("Enter sequence of positive integers seperated by a single" 
                + " space and the program calculates their sum:\n");
string input = Console.ReadLine() ?? "0";

Console.Write("Sum: ");
Console.WriteLine(input.Split().Select(int.Parse).Sum());

/* Input/Output:
Enter sequence of positive integers seperated by a single space and the program calculates their sum:
43 68 9 23 318
Sum: 461
*/