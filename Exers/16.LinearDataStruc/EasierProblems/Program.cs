/* Ex5 - Problem Statement:
Write a program, which removes all negative numbers from a sequence. 
Example: array = {19, -10, 12, -6, -3, 34, -2, 5} -> {19, 12, 34, 5}
*/

Random random = new Random();
List<int> intList = GenerateRandomList(random.Next(7, 17), random.Next(-17, -1), random.Next(1, 17));
PrintList(intList);
Console.Write(" -> ");

var removeNegatives = intList.FindAll(n => (n >= 0));
PrintList(removeNegatives);

void PrintList<T>(List<T> items)
{
    Console.Write("{ ");
    foreach (var item in items)
    {
        Console.Write($"{item} ");
    }
    Console.Write("}");
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

/* Output:
{ -8 7 5 10 3 10 -1 6 -6 -3 -2 4 } -> { 7 5 10 3 10 6 4 }
{ 8 -7 7 -5 -7 1 -8 4 8 -6 1 3 } -> { 8 7 1 4 8 1 3 }
{ 13 7 6 2 5 -1 2 -3 -2 0 2 -1 -1 12 11 -2 } -> { 13 7 6 2 5 2 0 2 12 11 }
*/