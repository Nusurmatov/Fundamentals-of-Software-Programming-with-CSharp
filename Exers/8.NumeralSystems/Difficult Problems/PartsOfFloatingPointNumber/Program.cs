/* (Difficult Problems) Ex15 - Problem Statement:
Write a program that prints the value of the mantissa, the sign of the
mantissa and exponent in float numbers (32-bit numbers with a
floating-point according to the IEEE 754 standard). Example: for the
number -27.25 should be printed: sign = 1, exponent = 10000011,
mantissa = 10110100000000000000000.
*/

float number = -27.25f;
Console.WriteLine($"Number: {number}");
byte[] floatNumber = BitConverter.GetBytes(number);


Console.WriteLine($"Sign: {BitConverter.ToString(floatNumber)}");
Console.WriteLine(Convert.ToString(floatNumber));