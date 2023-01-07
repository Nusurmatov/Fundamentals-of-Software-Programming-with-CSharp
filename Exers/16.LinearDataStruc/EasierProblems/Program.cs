/* Ex10 - Problem Statements:
We are given N and M and the following operations:
N = N+1
N = N+2
N = N*2
Write a program, which finds the shortest subsequence from the
operations, which starts with N and ends with M. Use queue.
Example: N = 5, M = 16
Subsequence: 5 -> 7 -> 8 -> 16
*/

Queue<int> queue = new Queue<int>();
Console.Write("Enter integer N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer M (M > N): ");
int m = Convert.ToInt32(Console.ReadLine());
queue.Enqueue(n);

Console.Write($"Subsequence: {n} -> ");
while (true)
{
    int s = queue.Dequeue();

    if (AddToQueueOptimized(s += 1)) break;
    if (AddToQueueOptimized(s += 2)) break;
    if (AddToQueueOptimized(s *= 2)) break;
}

bool AddToQueueOptimized(int number)
{
    if (number != m)
    {
        if (!queue.Contains(number))
        {
            queue.Enqueue(number);
            Console.Write($"{number} -> ");
        }
    
        return false;
    }
    else
    {
        Console.Write(number);
 
        return true;
    }
}

/* Output:
Enter integer N: 5
Enter integer M (M > N): 16
Subsequence: 5 -> 6 -> 8 -> 16

Enter integer N: 7
Enter integer M (M > N): 25
Subsequence: 7 -> 8 -> 10 -> 20 -> 9 -> 11 -> 22 -> 13 -> 26 -> 21 -> 23 -> 46 -> 10 -> 12 -> 24 -> 14 -> 28 -> 25
*/