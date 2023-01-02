/* (Medium) Ex4, 5 - Problems Statements:
4. You are given a set of strings. Write a recursive program, which generates all subsets, consisting exactly k strings chosen among the
elements of this set. Sample input: strings = {'test', 'rock', 'fun'}, k = 2 -> Sample output: (test rock), (test fun), (rock fun)
5. Write a recursive program, which prints all subsets of a given set of N words. Example input: words = {'test', 'rock', 'fun'}
Example output: (), (test), (rock), (fun), (test rock), (test fun), (rock fun), (test rock fun)
Think about and implement an iterative algorithm for both same tasks.
*/

class Program
{
    static string[] words = {"test", "rock", "fun", "bin"};
    static int k = 2;
    static int[] set = new int[words.Length];

    static void Main()
    {
        Console.WriteLine($"All subsets which has exactly {k} elements: ");
        GenerateSubsets(0);
        Console.WriteLine("\n\nAll Subsets: ");
        GenerateSubsets();
    }

    static void GenerateSubsets(int counter)
    {
        if (counter == k)
        {
            PrintLoop(k);
            return;
        }

        for (int i = 0; i < words.Length; i++)
        {
            set[counter] = i;
            
            if (counter != 0 && set[counter] <= set[counter-1])
            {
                continue;
            }

            GenerateSubsets(counter + 1);
        }
    }

    static void GenerateSubsets()
    {
        for (k = 0; k <= words.Length; k++)
        {
            GenerateSubsets(0);
        }
    }

    static void PrintLoop(int end)
    {
        Console.Write("( ");
        for (int i = 0; i < end; i++)
        {
            Console.Write($"{words[set[i]]} ");            
        }
        Console.Write(")   ");
    }
}

/* Output:
All subsets which has exactly 2 elements:
( test rock )   ( test fun )   ( rock fun )

All Subsets:
( )   ( test )   ( rock )   ( fun )   ( test rock )   ( test fun )   ( rock fun )   ( test rock fun )
*/