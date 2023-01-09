/* Difficult Problem, Exersice 15 - Problem Statement:
Implement numbers sorting in a dynamic linked list without using an additional array or other data structure.
*/

Console.Clear();
Random random = new Random();
List<int> list = new List<int>();

for (int i = 0; i < 17; i++)
{
    list.Add(random.Next(-17, 17));
    Console.Write($"{list[i]} ");
}

list.SortCustom();
Console.WriteLine();

for (int i = 0; i < 17; i++)
{
    Console.Write($"{list[i]} ");
}

/* Output:
Count: 6
{ six, five, four, one, two, three }

Item at front: three
Item at end: six

Count: 4
{ five, four, one, two }

Item at front: five
Item at end: two
Count: 4

Deque contains 'six': False
Deque contains 'one': True

Count: 0, Deque: Empty!
*/