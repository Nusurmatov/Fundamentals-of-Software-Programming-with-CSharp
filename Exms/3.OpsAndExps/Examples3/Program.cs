/* Operators and Expressions Examples */

// Arithmetic operators:
int squarePerimeter = 17;
double squareSide = squarePerimeter / 4.0;
double squareArea = squareSide * squareSide;
Console.WriteLine(squareSide); // 4.25
Console.WriteLine(squareArea); // 18.0625
int a = 5;
int b = 4;
Console.WriteLine(a + b); // 9
Console.WriteLine(a + (b++)); // 9
Console.WriteLine(a + b); // 10
Console.WriteLine(a + (++b)); // 11
Console.WriteLine(a + b); // 11
Console.WriteLine(14 / a); // 2
Console.WriteLine(14 % a); // 4
int one = 1;
int zero = 0;
// Console.WriteLine(one / zero); // DivideByZeroException
double dMinusOne = -1.0;
double dZero = 0.0;
Console.WriteLine(dMinusOne / zero); // -Infinity (-∞)
Console.WriteLine(one / dZero); // Infinity (∞)
Console.WriteLine("-----//-----//-----//-----//-----//-----");


// Bitwise operators:
byte c = 3; // 0000 0011 = 3
byte d = 5; // 0000 0101 = 5
Console.WriteLine(c | d); // 0000 0111 = 7
Console.WriteLine(c & d); // 0000 0001 = 1
Console.WriteLine(c ^ d); // 0000 0110 = 6
Console.WriteLine(~c & d); // 0000 0100 = 4
Console.WriteLine(c << 1); // 0000 0110 = 6
Console.WriteLine(c << 2); // 0000 1100 = 12
Console.WriteLine(c >> 1); // 0000 0001 = 1
Console.WriteLine("-----//-----//-----//-----//-----//-----");


/* Cascade assignement:
int x, y, z;
x = y = z = 25;
*/


// Other operators:
int? e = 5;
Console.WriteLine(e ?? -1); // 5
string name = null;
Console.WriteLine(name ?? "(no name)"); // (no name)

a = 6;
b = 3;
Console.WriteLine(a + b / 2); // 7
Console.WriteLine((a + b) / 2); // 4
string s = "Beer";
Console.WriteLine(s is string); // True
string notNullString = s;
string nullString = null;
Console.WriteLine(nullString ?? "Unspecified"); // Unspecified
Console.WriteLine(notNullString ?? "Specified"); // Beer
Console.WriteLine("-----//-----//-----//-----//-----//-----");


// Explicit conversions:
double myDouble = 5.1d;
Console.WriteLine(myDouble); // 5.1
long myLong = (long)myDouble;
Console.WriteLine(myLong); // 5
myDouble = 5e9d; // 5 * 10^9
Console.WriteLine(myDouble); // 5000000000
int myInt = (int)myDouble;
Console.WriteLine(myInt); // -2147483648
Console.WriteLine(int.MinValue); // -2147483648
Console.WriteLine("-----//-----//-----//-----//-----//-----");


// System.Overflow exeption:
double doub = 5000000000;
Console.WriteLine(doub); // 5000000000
int i = checked((int)doub); // System.OverflowException
Console.WriteLine(i);
