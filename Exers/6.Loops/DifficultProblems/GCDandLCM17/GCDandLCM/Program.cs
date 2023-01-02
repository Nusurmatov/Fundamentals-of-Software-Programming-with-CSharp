/* (Difficult Problems) Ex17 - Problem Statement:
Write a program that given two numbers finds their greatest common divisor (GCD) and their 
least common multiple (LCM). You may use the formula LCM(a, b) = |a*b| / GCD(a, b).
*/

Console.Write("Enter a positive integer: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter another positive integer: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int gcd = 1;   //LCM - Least Common Multiple  
int lcm = num1 * num2;    // GCD(a, b) * LCM(a, b) = a * b  =>  LCM(a, b) = a * b / GCD(a, b). 

while (num2 != 0)    // Euclidean Algorithm for finding Greates Common Divisor
{
    gcd = num2;
    num2 = num1 % num2;
    num1 = gcd;
}

Console.WriteLine($"GCD (Greatest Common Divisor): {gcd}  |  LCM (Least Common Multiple): {(lcm/gcd)}");

/* Input/Output:
Enter a positive integer: 80
Enter another positive integer: 324
GCD (Greatest Common Divisor): 4  |  LCM (Least Common Multiple): 6480
*/