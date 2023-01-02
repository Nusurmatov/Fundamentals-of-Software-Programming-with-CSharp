/* (Difficult) Ex7: Problem Statement:
Write a recursive program, which generates and prints all permutations of the numbers 1, 2, …, n, for a given integer n. 
Example input: n = 3 Example output: (1, 2, 3), (1, 3, 2), (2, 1, 3), (2, 3, 1), (3, 1, 2), (3, 2, 1)
Try to find an iterative solution for generating permutations.
*/

int n = 3;
int[] permutations = Enumerable.Range(1, n).ToArray();
GeneratePermutations(n - 1);

void GeneratePermutations(int counter)
{
    if (counter == 0)
    {
        PrintPermutations();
        return;
    }

    GeneratePermutations(counter - 1);

    for (int i = 0; i < counter; i++)
    {
//        PrintPermutations();
        permutations[i] = permutations[counter];

        GeneratePermutations(counter - 1);
        permutations[i] = permutations[counter];
    }
}

void PrintPermutations()
{
    Console.Write("( ");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{permutations[i]} ");
    }
    Console.WriteLine(")");
}

/* Output:
( 1 2 1 )
( 1 2 3 )
( 1 3 1 )
( 1 3 2 )
( 2 1 2 )
( 2 1 3 )
( 2 3 1 )
( 2 3 2 )
( 3 1 2 )
( 3 1 3 )
( 3 2 1 )
( 3 2 3 )
*/