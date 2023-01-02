/* Problem Statement
We are given 5 integer numbers. Write a program that finds those
subsets whose sum is 0. Examples:
- If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 is 0.
- If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets with sum 0.
*/

// Ex9 - Calculate subsets of five integers whose sum is 0:

Console.WriteLine(@"
This program accepts five integers and finds those subsets whose sum is 0 Examples:
- If the numbers are {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 is 0.
- If the numbers are {3, 1, -7, 35, 22}, there are no subsets with sum 0.");

int counter = 0;
bool unDone = true;
int[] numberSet = new int[5];

while (unDone)
{
    Console.Write($"Enter number{(counter + 1)}: ");
    int num;

    if (int.TryParse(Console.ReadLine(), out num))
    {
        numberSet[counter] = num;
        counter++;
    }
    else
    {
        Console.WriteLine(@"
Invalid input. Now you have three options:
               Option 1: You can continue by entering 1 or c (continue for short).
               Option 2: You can stop there and see the result by entering 2 or s (stop for short).
               Option 3: You can just quit by
");
        string input = Console.ReadLine() ?? "";
        if (input.Trim().ToLowerInvariant() == "quit")
        {
            unDone = false;
        }
    }

    if (counter == 5)
    {
        unDone = false;
    }
}

for (int i = 0; i < numberSet.Length; i++)
{

}

/* Input/Output:
 
This program accepts a score int the range [1...9] and gives bonus points by the following rules:
- If the score is between 1 and 3, the program multiplies it by 10.
- If the score is between 4 and 6, the program multiplies it by 100.
- If the score is between 7 and 9, the program multiplies it by 1000.
- If the score is 0 or more than 9, the program prints an error message.
Now enter a score (1,...9): 7
Final points: 7000

This program accepts a score int the range [1...9] and gives bonus points by the following rules:
- If the score is between 1 and 3, the program multiplies it by 10.
- If the score is between 4 and 6, the program multiplies it by 100.
- If the score is between 7 and 9, the program multiplies it by 1000.
- If the score is 0 or more than 9, the program prints an error message.
Now enter a score (1,...9): 10
Invalid input...!
Final points: 10
*/