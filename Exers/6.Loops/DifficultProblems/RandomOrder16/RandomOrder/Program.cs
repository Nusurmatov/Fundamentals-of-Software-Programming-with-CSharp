/* (Difficult Problems) Ex16 - Problem Statement:
Write a program that by a given integer N prints the numbers from 1 to N
in random order.
*/

Console.Write("Enter a positive integer: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("How many times do you want to print numbers from 1 to N in random order? : ");
int count = Convert.ToInt32(Console.ReadLine());

int[] numbers = Enumerable.Range(1, n).ToArray();   // Array of numbers from 1 to n.
Random ran = new Random();

Console.Write("In order: ");
PrintArrayElements(numbers, n);

for (int i = 0; i < count; i++)
{
    SwapArrayElements(numbers, n);
    Console.Write("\nIn Random order {0}: ", i+1);
    PrintArrayElements(numbers, n);
}

void SwapArrayElements(int[] numbers, int n)    // swap two random numbers in the array 'numbers' n times.
{
    for (int k =0; k < n; k++)
    {
        int i = ran.Next(1, n);
        int j = ran.Next(1,n);
        numbers[i] = numbers[i] ^ numbers[j];   // swap two values at index i and j with bitwise algorithm. 
        numbers[j] = numbers[j] ^ numbers[i];
        numbers[i] = numbers[i] ^ numbers[j];
    }
}

void PrintArrayElements(int[] numbers, int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0} ", numbers[i]);
    }
}

/* Input/Output:
Enter a positive integer: 17
How many times do you want to print numbers from 1 to N in random order? : 7
In order: 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17
In Random order 1: 1 2 9 11 5 13 6 15 17 10 4 0 7 14 12 0 16 
In Random order 2: 1 0 0 13 0 17 9 7 16 2 0 5 15 14 12 10 6  
In Random order 3: 1 0 7 10 5 13 0 17 0 14 9 0 15 2 12 6 16  
In Random order 4: 1 9 7 6 0 10 0 15 0 14 13 0 0 2 0 12 16   
In Random order 5: 1 12 14 15 0 0 9 7 16 10 13 0 0 2 0 0 0   
In Random order 6: 1 0 16 15 14 0 13 7 0 10 0 0 0 9 12 2 0
In Random order 7: 1 0 15 12 10 13 0 16 0 7 0 0 0 0 0 14 2 
*/