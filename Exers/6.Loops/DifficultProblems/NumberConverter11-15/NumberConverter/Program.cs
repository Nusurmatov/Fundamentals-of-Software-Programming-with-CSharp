using System.Text;
using NumberConverter;

ConsoleColor back = ConsoleColor.White;
ConsoleColor front = ConsoleColor.Magenta;
Console.BackgroundColor = back;
Console.ForegroundColor = front;
Console.Clear();

int option = 4;
bool unDone = true;
string input = String.Empty;
string result = String.Empty;
int fromBase = 10;
int toBase = 2;
Console.WriteLine("Checking 5 public static custom methods: ");

while(unDone)
{
    StringBuilder instruction = new StringBuilder("Choose one of following options: \n");
    instruction.AppendLine("To convert decimal to binary, enter 0,");
    instruction.AppendLine("To convert binary to decimal, enter 1,");
    instruction.AppendLine("To convert decimal to hexadecimal, enter 2,");
    instruction.AppendLine("To convert hexadecimal to decimal, enter 3,");
    instruction.AppendLine("To convert base N to Base M, enter 4,");
    instruction.AppendLine("To convert binary to decimal using Horner Scheme, enter 5,");
    instruction.AppendLine("To convert Roman number to Arabic, enter 6,");
    instruction.AppendLine("To convert Arabic number to Roman, enter 7,");
    instruction.AppendLine("Or just enter 8 to quit, ");
    instruction.AppendLine("Default option is 4. This is automatically chosen" + 
                      " if you enter wrong option or invalid input...!");
    instruction.Append("\nAnd your option: ");
    Console.Write(instruction);

    if (int.TryParse(Console.ReadLine(), out option))
    {
        switch(option)
        {
            case 0:
                Console.Write("Enter a positive decimal number: ");
                input = Console.ReadLine() ?? "invalid";
                result = ConvertNumber.FromPositiveIntegerToBinary(input);
                break;
            case 1:
                Console.Write("Enter a binary number: ");
                input = Console.ReadLine() ?? "invalid";
                result = ConvertNumber.FromBinaryToPositiveInteger(input);
                break;
            case 2:
                Console.Write("Enter a decimal number: ");    
                input = Console.ReadLine() ?? "invalid";
                result = ConvertNumber.FromPositiveIntegerToHexadecimal(input);
                break;
            case 3:
                Console.Write("Enter a hexadecimal number: ");
                input = Console.ReadLine() ?? "invalid";
                result = ConvertNumber.FromHexadecimalToPositiveInteger(input);
                break;
            case 4:
            default:
                try 
                {
                    Console.Write("Enter a base you want to convert a number from: ");
                    fromBase = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Now enter a base {fromBase} number: ");
                    input = Console.ReadLine() ?? "invalid";
                    Console.Write("Now, enter a base you want convert a number to: ");
                    toBase = Convert.ToInt32(Console.ReadLine());
                    result = ConvertNumber.FromBaseNToBaseM(input, fromBase, toBase);
                }   
                catch(Exception) 
                {
                    result = "Invalid base";
                }
                break;
            case 5:
                Console.Write("Enter a binary number: ");
                input = Console.ReadLine() ?? "";
                result = ConvertNumber.HornerScheme(input);
                break;
            case 6:
                Console.Write("Enter a Roman Number: ");
                input = Console.ReadLine() ?? "";
                result = ConvertNumber.FromRomanToArabic(input);
                break;
            case 7:
                Console.Write("Enter a Arabic number: ");
                input = Console.ReadLine() ?? "";
                result = ConvertNumber.FromArabicToRoman(input);
                break;
            case 8:
                unDone = false;
                break;
        }

        Console.Clear();
        Console.WriteLine(unDone ? $"Entered: {input}" : "Thank you...!");
        Console.Write(unDone ? $"Result: {result}" : "");
        Console.Write("\n\nPress any key to ");
        Console.Write(unDone ? "continue: " : "quit: ");
        Console.ReadKey();
        Console.Clear();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Invalid option...!\n");
    }
}