/* Ex1 - Problem Statement:
Write a program that reads from the console a sequence of positive
integer numbers. The sequence ends when empty line is entered.
Calculate and print the sum and the average of the sequence. Keep
the sequence in List<int>.
*/

bool undone = true;
List<int> intList = new List<int>();
int input;

while (undone)
{
    Console.Write("Enter a positeve integer or nothing to quit: ");
    if (int.TryParse(Console.ReadLine(), out input))
    {
        intList.Add(input);
    }
    else
    {
        undone = false;
    }
}

Console.WriteLine("Sum of entered integers: {0}", intList.Sum());
Console.WriteLine("Average of entered integers: {0}", Math.Round(intList.Average(), 2));

/* Input/Output:
Enter a positeve integer or nothing to quit: 7
Enter a positeve integer or nothing to quit: 8
Enter a positeve integer or nothing to quit: 9
Enter a positeve integer or nothing to quit: 17
Enter a positeve integer or nothing to quit: 35
Enter a positeve integer or nothing to quit: 78
Enter a positeve integer or nothing to quit:
Sum of entered integers: 154
Average of entered integers: 25.67
*/