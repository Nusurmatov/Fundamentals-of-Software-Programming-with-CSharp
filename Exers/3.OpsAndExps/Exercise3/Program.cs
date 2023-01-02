/* Exe16: Exchange bits */

/* Problem statement:
* Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q,
q+1, …, q+k-1} of a given 32-bit unsigned integer.
*/

Console.Write("Enter an unsigned integer: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter an integer for p: ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter an integer for q: ");
int q = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter an integer for k: ");
int k = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= k; i++, p++, q++)
{
    int bitP = (num >> p) & 1;
    int bitQ = (num >> q) & 1;
    num = num & (~(1 << q)) | (bitP << q);
    num = num & (~(1 << p)) | (bitQ << p);
}

Console.WriteLine("After applying changes: {0}", num);

/* Input/Ouput:
Enter an unsigned integer: 5648
Enter an integer for p: 7
Enter an integer for q: 17
Enter an integer for k: 7
After applying changes: 5767184
*/
