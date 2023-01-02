/* (Easier Problems) Ex7 - Problem Statement:
Write a method that prints the digits of a given decimal number in a
reversed order. For example 256, must be printed as 652.
*/

Console.Write("Enter a decimal number: ");
Console.Write("Reversed: {0}", GetReverseOrder(Console.ReadLine() ?? "Invalid Input!"));

string GetReverseOrder(string number)
{
    string result = String.Empty;
    for (int i = number.Length - 1; i >= 0; i--)
    {
        result += number[i];
    }

    
    return int.TryParse(result, out int n) ? result : "Invalid Input!";
}

/* Input/Output:
Enter a decimal number: 707+7
Reversed: Invalid Input!
Enter a decimal number: 784647
Reversed: 746487
Enter a decimal number: 76472
Reversed: 27467
*/