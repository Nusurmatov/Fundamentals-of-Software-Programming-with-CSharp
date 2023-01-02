while (true) 
{
    Console.Write("Enter a positive number or 'exit' to quit: "); 
    string? input = Console.ReadLine();
    
    if (input.Trim().ToLower().Contains("exit"))
    {
        break;
    }

    double number = double.Parse(input);
    if (number >= 0)
    {
        Console.WriteLine($"The number is {number} and the square root of it is {System.Math.Sqrt(number)}");
    }
    else 
    {
        Console.WriteLine("Please enter a positive number...!");
    }
}

/* Output:
Enter a positive number or 'exit' to quit: 225
The number is 225 and the square root of it is 15
Enter a positive number or 'exit' to quit: 51
The number is 51 and the square root of it is 7.14142842854285
Enter a positive number or 'exit' to quit: 0.81
The number is 0.81 and the square root of it is 0.9
Enter a positive number or 'exit' to quit: EXit
PS E:\KhN\IT\.NET Development\FofCP with C#\Exers\1. IntroToPro\9.SquareRoot\squareroot> 
*/