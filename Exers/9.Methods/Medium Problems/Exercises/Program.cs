/* (Medium Problems) Ex10 - Problem Statement:
Write a program that calculates and prints the n! for any n in the range [1…100].
*/

int n = 100;
Console.Write($"{n}! = ");
byte[] factorial = CalculateFactorial(n);
PrintArrayAsNumber(factorial);

byte[] CalculateFactorial(int n)
{
    byte[] factorial = new byte[160];
    factorial[0] = 1;
    int carry = 0;
    int i, j;
    int factLength = 1;
    int previousDigit = 1;

    for (i = 1; i <= n; i++)
    {
        for (j = 0; ; j++)
        {
            if (factorial[j] == 0 && carry == 0 && j >= factLength)
            {
                break;
            }

            if (j == 0)
            {
                previousDigit = factorial[j];
                factorial[j] = (byte) ((factorial[j] * i) % 10);
                carry = (previousDigit * i) / 10;
            }
            else
            {
                previousDigit = factorial[j];
                factorial[j] = (byte) ((factorial[j] * i + carry) % 10);
                carry = (previousDigit * i + carry) / 10;
            }
        }
        factLength = j;
    }

    Array.Resize(ref factorial, factLength);
    return factorial;
}

void PrintArrayAsNumber(byte[] array)
{
    Array.Reverse(array);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}

/* Input/Output:
100! = 93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000
30! = 265252859812191058636308480000000
*/
