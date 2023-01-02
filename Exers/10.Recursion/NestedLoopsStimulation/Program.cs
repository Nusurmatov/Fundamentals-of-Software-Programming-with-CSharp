/* (Easier) Ex1 - Problems Statement:
Write a program to simulate n nested loops from 1 to n.
*/

int n = 11, t = 7;
NestedLoops(n-1);

void NestedLoops(int k)
{
    if (k == 0)
    {
        return;
    }

    NestedLoops(k-1);
    
    Console.WriteLine($"{t,3} x{k,3} = {(t * k), 2}");
}

/* Output:
  7 x  1 =  7
  7 x  2 = 14
  7 x  3 = 21
  7 x  4 = 28
  7 x  5 = 35
  7 x  6 = 42
  7 x  7 = 49
  7 x  8 = 56
  7 x  9 = 63
  7 x 10 = 70
*/