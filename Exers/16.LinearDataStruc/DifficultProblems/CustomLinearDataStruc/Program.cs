/* Difficult Problem, Exersice 12 - Problem Statement:
Create a DynamicStack<T> class to implement dynamically a stack (like a linked list, 
where each element knows its previous element and the stack knows its last element). 
Add methods for all commonly used operations like Push(), Pop(), Peek(), Clear() and Count.
*/

Console.Clear();

var stack = new Stack<string>();
var customStack = new DynamicStack<string>();

stack.Push("one");
stack.Push("two");
stack.Push("three");
stack.Push("four");
stack.Push("five");

customStack.Push("one");
customStack.Push("two");
customStack.Push("three");
customStack.Push("four");
customStack.Push("five");

Console.Write("This is coming from Stack: ");
foreach (var item in stack)
{
    Console.Write($"{item} ");
}

Console.Write("This is coming from Custom Stack: ");
foreach (var item in customStack)
{
    Console.Write($"{item} ");
}

Console.WriteLine($"Stack.Pop() - {stack.Pop()}, and the count - {stack.Count}");
Console.WriteLine($"Stack.Peek() - {stack.Peek()}, and the count - {stack.Count}");

Console.WriteLine($"CustomStack.Pop() - {customStack.Pop()}, and the count - {customStack.Count}");
Console.WriteLine($"CustomStack.Peek() - {customStack.Peek()}, and the count - {customStack.Count}");

/* Output:
{ Apples, Meat, Olives, Coffee, Milk, Honey, Water, Bananas }
Item at position 3: Coffee
Item at position 4: Milk
Size: 8
Is there milk in the list? True
Index of honey: 5
Index of mango: -1     

Size: 4
Meat Coffee Milk Water 
*/