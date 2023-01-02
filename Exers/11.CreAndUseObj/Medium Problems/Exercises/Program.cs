/* (Medium) - Ex6 - Problems Statement:
Write a program which calculates the area of a triangle with the following given:
- three sides;
- side and the altitude to it;
- two sides and the angle between them in degrees.
*/

using System.Text;

class Triangle
{
    public class Area
    {
        static double area;
        
        public double FindByHeronFormula(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }

        public double FindBySideAndAltitude(double a, double h)
        {
            area = (a * h) / 2;

            return area;
        }

        public double FindByTwoSidesAndAngle(double a, double b, double angle)
        {
            area = (a * b * Math.Sin(angle / 180)) / 2;

            return area;
        }

        public override string ToString()
        {
            return area.ToString();
        }
    }
}

class TriangleAreaTest
{
    static double a = 1, b = 1, c = 1, h = 1, angle = 1, area;
    static string output = String.Empty;
    
    static void Main()
    {
        SetBackground();

        Triangle.Area triangle = new Triangle.Area();
        bool undone = true;

        while (undone)
        {
            char option = ChooseOptions();

            switch (option)
            {
                case '0':
                    AcceptInput('a', 'b', "c");
                    if (a > 0 && b > 0 && c > 0)
                        area = triangle.FindByHeronFormula(a, b, c);
                    break;
                case '1':
                    AcceptInput('a', 'h');
                    if (a > 0 && h > 0)
                        area = triangle.FindBySideAndAltitude(a, h);
                    break;
                case '2':
                    AcceptInput('a', 'b', "angle");
                    if (a > 0 && b > 0 && angle > 0)
                        area = triangle.FindByTwoSidesAndAngle(a, b, angle);
                    break;
                case '3':
                    output = "Thank you...!\n";
                    undone = false;
                    break;
                case '4':
                    break;
                case '5':
                    break;
            }

            // if (a <= 0 || b <= 0 || c <= 0 || angle <= 0 || (option > 50 && option < 53))
            // {
            //     Console.Clear();
            //     Console.WriteLine(output);
            // }
       //     else
            {
                Console.WriteLine("Area of Triangle: {0}", area);
                Console.Write("\nPress any key to continue: ");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    static void SetBackground(ConsoleColor front = ConsoleColor.DarkBlue, ConsoleColor back = ConsoleColor.White)
    {
        Console.ForegroundColor = front;
        Console.BackgroundColor = back;
        Console.Clear();
        Console.WriteLine(" ------------     This program calculates the area of a triagle      ------------\n");
    }

    static char ChooseOptions()
    {
        char option;  

        StringBuilder message = new StringBuilder("Choose one of following options:\n");  {
            message.AppendLine("To calculate the area of triangle by");
            message.AppendLine("    - three sides, enter 0;");
            message.AppendLine("    - a side and the altitude to it, enter 1;");
            message.AppendLine("    - two sides and the angle between them, enter 2;");
            message.AppendLine("Or to quit enter 3.");
            message.Append("\nAnd your option: "); 
        }

        Console.Write(message);
        if (char.TryParse(Console.ReadLine(), out option))
        {
            if (option < 48 || option > 51)
            {
                output = $"There is no such option as {option}...!";
                option = '4';
            }
        }
        else
        {
            output = "Invalid Input...!";
            option = '5';
        }

        return option;
    }

    static double ConvertToDouble(string input)
    {
        double result;

        if (double.TryParse(input, out result))
        {
            if (result == 0)
            {
                a = 0.0d;
                result = 0.0d;
                output = "Triangle sides, altitudes and angles cannot be zero...!";
            }
            else if (result < 0)
            {
                a = 0.0d;
                result = -1.0d;
                output = "Triangle sides, altitudes and angles cannot be less than zero...!";
            }
        }
        else
        {
            if (input == "null")
            {
                a = 0.0d;
                result = -2.0d;
                output = "You entered noting...!";
            }
            else
            {
                a = 0.0d;
                result = -3.0d;
                output = "Invalid input...!";
            }
        }

        return result;
    }

    static void AcceptInput(char side1, char sideOrAltitude, string sideOrAngle = "")
    {
        Console.Write("Enter first side: a = ");
        a = ConvertToDouble(Console.ReadLine() ?? "null");

        Console.Write("Enter ");
        if (sideOrAltitude == 'b')
        {
            Console.Write("second side: b = ");
            b = ConvertToDouble(Console.ReadLine() ?? "null");
        }
        else
        {
            Console.Write("altitude to that side: h = ");
            h = ConvertToDouble(Console.ReadLine() ?? "null");
        }

        if (sideOrAngle == "c")
        {
            Console.Write("Enter third side: c = ");
            c = ConvertToDouble(Console.ReadLine() ?? "null");
        }   
        else if (sideOrAngle == "angle")
        {
            Console.Write("Enter angle between these two sides: angle = ");
            angle = ConvertToDouble(Console.ReadLine() ?? "null");
        }     
    }
}

/* Input/Output:
This is a great product. You should try it too. I am very satisfied. -- Kate, New York.
I use this product constantly. I managed to change. -- Stella, Berlin.
The product is excellent. You should try it too. I am very satisfied. -- Hellen, Paris.
The product is excellent. Now, I feel better. -- Kate, New York.
*/