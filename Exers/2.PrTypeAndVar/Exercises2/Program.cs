/* Ex13: Swapping two integers */

int num = -1;
double denum = 0; // The value is 0.0 (real number)
int zeroInt = (int) denum; // The value is 0 (integer number)
Console.WriteLine(num / denum); // Infinity
Console.WriteLine(denum / denum); // NaN
Console.WriteLine(zeroInt / zeroInt); // DivideByZeroException

/* Output:
a = 5, b = 10
After swapping:
a = 10, b = 5  
After swapping:
a = 5, b = 10  
After swapping:
a = 10, b = 5
After swapping:
a = 5, b = 10
*/

/* Answer:
Two floating-point values are considered equel if their 
difference is less than some predefined precision(e.g. 0.000001) 
*/