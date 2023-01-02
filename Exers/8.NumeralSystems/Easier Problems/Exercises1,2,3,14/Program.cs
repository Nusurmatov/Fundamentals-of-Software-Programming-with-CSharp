/* (Easier Problems) Ex3 - Problems Statement:
Try adding up 50,000,000 times the number 0.000001. Use a loop
and addition (not direct multiplication). Try it with float and double and
after that with decimal. Do you notice the huge difference in the
results and speed of calculation? Explain what happens.
*/

using System.Diagnostics;

Stopwatch time = Stopwatch.StartNew(); 
float floatSum = 0.0f;
for (int i = 0; i < 50000000; i++)
{
    floatSum += 0.000001f;
}
time.Stop();
Console.WriteLine("Float Sum Result: {0}", floatSum);
Console.WriteLine("Execution Time: {0}ms", time.ElapsedMilliseconds);

time = Stopwatch.StartNew();
double doubleSum = 0.0d;
for (int i = 0; i < 50000000; i++)
{
    doubleSum += 0.000001;
}
time.Stop();
Console.WriteLine("\nDouble Sum Result: {0}", doubleSum);
Console.WriteLine("Execution Time: {0}ms", time.ElapsedMilliseconds);

time = Stopwatch.StartNew();
decimal decimalSum = 0.0m;
for (int i = 0; i < 50000000; i++)
{
    decimalSum += 0.000001m;
}
time.Stop();
Console.WriteLine("\nDecimal Sum Result: {0:N2}", decimalSum);
Console.WriteLine("Execution Time: {0}ms", time.ElapsedMilliseconds);

/* Output:
Float Sum Result: 32
Execution Time: 225ms

Double Sum Result: 49.999999965778784
Execution Time: 233ms

Decimal Sum Result: 50.00
Execution Time: 1778ms
*/