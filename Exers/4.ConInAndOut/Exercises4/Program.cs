// Ex12: Calculate the sum of 1 + 1/2 - 1/3 + 1/4 - 1/5 +... with precision 0.001:

Console.WriteLine("This program calculates the sum of the sequence,  " +
                  "1 + 1/2 - 1/3 + 1/4 - 1/5 +..., with precision 0.001.");

decimal oldSum = 0, currentSum = 0;
for (int i = 1; ; i++)
{
    currentSum += (i > 1 && i % 2 == 1) ? (-1.0m / i) : (1.0m / i);
    
    if (Math.Abs((double)currentSum - (double)oldSum) < 0.001) break;
    
    oldSum = currentSum;
}

Console.WriteLine($"The sum with precision 0.001: {currentSum:f3}");

Console.ReadKey();

/* Input/Output: 
This program calculates the sum of the sequence,  1 + 1/2 - 1/3 + 1/4 - 1/5 +..., with precision 0.001.
The sum with precision 0.001: 1.307
*/