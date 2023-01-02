// Calculates Area of Rectangle or Triangle:

Console.WriteLine("This program calculates " +
"the area of a rectangle or a triangle");
Console.Write("Enter a and b (for rectangle) " +
"or a and h (for triangle): ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.Write("Enter 1 for a rectangle or " +
"2 for a triangle: ");
int choice = int.Parse(Console.ReadLine());
double area = (double) (a * b) / choice;  // very good logic...
Console.WriteLine("The area of your figure is " + area);


/* Input/Ouput:
This program calculates the area of a rectangle or a triangle
Enter a and b (for rectangle) or a and h (for triangle): 5
7
Enter 1 for a rectangle or 2 for a triangle: 1
The area of your figure is 35
This program calculates the area of a rectangle or a triangle
Enter a and b (for rectangle) or a and h (for triangle): 9
8
Enter 1 for a rectangle or 2 for a triangle: 2
The area of your figure is 36
*/


