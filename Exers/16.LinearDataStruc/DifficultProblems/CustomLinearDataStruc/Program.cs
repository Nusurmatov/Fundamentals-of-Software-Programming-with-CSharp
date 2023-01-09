/* Difficult Problem, Exersice 12 - Problem Statement:
Implement the data structure "Deque". This is a specific list-like structure, similar to stack and queue, 
allowing to add elements at the beginning and at the end of the structure. Implement the operations for adding 
and removing elements, as well as clearing the deque. If an operation is invalid, throw an appropriate exception.
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

Console.Write("This is coming from Stack:          ");
foreach (var item in stack)
{
    Console.Write($"{item} ");
}

Console.Write("\nThis is coming from Custom Stack:   ");
foreach (var item in customStack)
{
    Console.Write($"{item} ");
}

Console.WriteLine("\n\nStack contains 'three': {0}", stack.Contains("three"));
Console.WriteLine("Custom Stack contains 'three': {0}", customStack.Contains("three"));

Console.WriteLine($"\nStack Count - {stack.Count}, Stack.Pop() - {stack.Pop()}");
Console.WriteLine($"Stack Count - {stack.Count}, Stack.Peek() - {stack.Peek()}");

Console.WriteLine($"\nCustom Stack Count - {customStack.Count}, CustomStack.Pop() - {customStack.Pop()}");
Console.WriteLine($"Custom Stack Count - {customStack.Count}, CustomStack.Peek() - {customStack.Peek()}");

Console.WriteLine("\nStack can Peek now: {0}", stack.TryPeek(out string? resultStackPeek));
Console.WriteLine("Custom Stack can Peek now: {0}\n", customStack.TryPeek(out string? resultCustomStackPeek));

Console.WriteLine("ToString() - {0}", stack);
Console.Write("ToString() - {0}", customStack);

stack.Clear();  
customStack.Clear();  

Console.WriteLine("\nStack Count {0}", stack.Count);
Console.WriteLine("Custom Stack Count: {0}", customStack.Count);

Console.WriteLine("\nStack can Pop now: {0}", stack.TryPop(out string? resultStackPop));
Console.WriteLine("Custom Stack can Pop now: {0}", customStack.TryPop(out string? resultCustomStackPop));

/* Output:
This is coming from Stack:          five four three two one
This is coming from Custom Stack:   five four three two one   

Stack contains 'three': True
Custom Stack contains 'three': True

Stack Count - 5, Stack.Pop() - five
Stack Count - 4, Stack.Peek() - four

Custom Stack Count - 5, CustomStack.Pop() - five
Custom Stack Count - 4, CustomStack.Peek() - four

Stack can Peek now: True
Custom Stack can Peek now: True

ToString() - System.Collections.Generic.Stack`1[System.String]
ToString() - { four, three, two, one }

Stack Count 0
Custom Stack Count: 0

Stack can Pop now: False
Custom Stack can Pop now: False 
*/