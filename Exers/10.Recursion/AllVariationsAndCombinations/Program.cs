/* (Medium) Ex2, 3 - Problems Statements:
Write a program to generate all variations/combinations with duplicates of n
elements class k. Sample input: n = 3, k = 2 -> Sample output for ex2:
(1 1), (1 2), (1 3), (2 1), (2 2), (2 3), (3 1), (3 2), (3 3).
Sample output for ex3: (1 1), (1 2), (1 3), (2 2), (2 3), (3 3).
Think about and implement an iterative algorithm for the same task.
*/

int n = 3;  // number of loops
int k = 2;  // number of iterations
int[] loops = new int[k];
long allPossibbleVariations = (long) Math.Pow(n, k);

Console.WriteLine($"n = {n}, k = {k} --> All Variations:");
Generate(0, isVariation: true);
Console.WriteLine($"\n\nn = {n}, k = {k} --> All Combinations:");
Generate(0, isCombination: true);

void Generate(int currentLoop, bool isVariation = true, bool isCombination = false)
{
    if (currentLoop == k)
    {
        PrintLoop();
        return;
    }

    if (!isCombination)
    {
        for (int i = 1; i <= n; i++)
        {
            loops[currentLoop] = i;
            Generate(currentLoop + 1);
        }
    }
    else
    {
        for (int i = 1; i <= n; i++)
        {
            loops[currentLoop] = i;
            if (currentLoop != 0 && loops[currentLoop] < loops[currentLoop - 1])
            {
                continue;
            }

            Generate(currentLoop + 1, isCombination: true);
        }
    }
}

void PrintLoop()
{
    Console.Write("(");
    for (int i = 0; i < k; i++)
    {  
        Console.Write( i != k - 1 ? $"{loops[i]}, " : $"{loops[i]}) ");
    }
}

/* Output:
n = 3, k = 2 --> All Variations:
(1, 1) (1, 2) (1, 3) (2, 1) (2, 2) (2, 3) (3, 1) (3, 2) (3, 3) 

n = 3, k = 2 --> All Combinations:
(1, 1) (1, 2) (1, 3) (2, 2) (2, 3) (3, 3)
*/