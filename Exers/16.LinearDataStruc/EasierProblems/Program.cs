/* Ex4 - Problem Statement:
Write a method that finds the longest subsequence of equal numbers
in a given List<int> and returns the result as new List<int>. Write a
program to test whether the method works correctly.
*/

Random random = new Random();
List<int> intList = GenerateRandomList(random.Next(1, 17), random.Next(1, 7), random.Next(7, 10));

 void PrintList<T>(List<T> items)
{
    Console.Write("{ ");
    foreach (var item in items)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine("}");
}
    
 List<int> GenerateRandomList(int length, int lowerBound, int upperBound)
{
    var result = new List<int>();

    for (int i = 0; i < length; i++)
    {
        result.Add(random.Next(lowerBound, upperBound));
    }

    return result;
}

/* Input/Output:
Enter a positeve integer or nothing to quit: 7
Enter a positeve integer or nothing to quit: 79
Enter a positeve integer or nothing to quit: 1654
Enter a positeve integer or nothing to quit: 4
Enter a positeve integer or nothing to quit: 654
Enter a positeve integer or nothing to quit: 7
Enter a positeve integer or nothing to quit: 98
Enter a positeve integer or nothing to quit: 
Entered integers after Ascending Sorting: 4 7 7 79 98 654 1654 
*/