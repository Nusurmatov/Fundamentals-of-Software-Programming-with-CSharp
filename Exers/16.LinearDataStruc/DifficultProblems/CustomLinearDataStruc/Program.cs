/* Difficult Problem, Exersice 15 - Problem Statement:
Implement numbers sorting in a dynamic linked list without using an additional array or other data structure.
*/

Console.Clear();
Random random = new Random();
List<int> list = new List<int>();

for (int i = 0; i < 17; i++)
{
    list.Add(random.Next(-17, 17));
}

Console.WriteLine("Sorting in ascending order: ");
list.Print();
list.SortCustom();
list.Print();

Console.WriteLine("\nSorting in descending order: ");
list.SortCustom(IsAscending: false);
list.Print();

/* Output:
Sorting in ascending order:
{ 9 -12 -3 -4 -7 8 -1 -12 10 7 -16 7 -2 -12 2 -13 -7 }
{ -16 -13 -12 -12 -12 -7 -7 -4 -3 -2 -1 2 7 7 8 9 10 }

Sorting in descending order:
{ 10 9 8 7 7 2 -1 -2 -3 -4 -7 -7 -12 -12 -12 -13 -16 }
*/