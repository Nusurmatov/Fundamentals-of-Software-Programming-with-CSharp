/* Difficult Problem, Exersice 14 - Problem Statement:
Implement the structure "Circular Queue" with array, which doubles its capacity when its capacity is full. 
Implement the necessary methods for adding, removing the element in succession and retrieving without removing 
the element in succession. If an operation is invalid, throw an appropriate exception.
*/

Console.Clear();
CircularQueue<string> cQueue = new CircularQueue<string>();

cQueue.Enqueue("one");
cQueue.Enqueue("two");
cQueue.Enqueue("three");
cQueue.Enqueue("four");
cQueue.Enqueue("five");
cQueue.Enqueue("six");
cQueue.Enqueue("seven");

Console.WriteLine("Count: {0}", cQueue.Count);
Console.WriteLine(cQueue);

Console.WriteLine("\nDequeueing: {0}", cQueue.Dequeue());
Console.WriteLine("Dequeueing: {0}", cQueue.Dequeue());
Console.WriteLine("Dequeueing: {0}", cQueue.Dequeue());
Console.WriteLine("Peeking: {0}", cQueue.Peek());
Console.WriteLine("Count: {0}", cQueue.Count);
cQueue.Print();

Console.WriteLine("\nCircular Queue contains 'seven': {0}", cQueue.Contains("seven"));
Console.WriteLine("Circular Queue contains 'one': {0}", cQueue.Contains("one"));

cQueue.Clear();
Console.WriteLine("\nClearing...");
Console.WriteLine("Count: {0}", cQueue.Count);
Console.WriteLine("Circular Queue now: {0}", cQueue);

/* Output:
Count: 7
{ one, two, three, four, five, six, seven }

Dequeueing: one
Dequeueing: two
Dequeueing: three
Peeking: four
Count: 4
{ four five six seven }

Circular Queue contains 'seven': True
Circular Queue contains 'one': False

Clearing...
Count: 0
Circular Queue now: Circular Queue is Empty!
*/