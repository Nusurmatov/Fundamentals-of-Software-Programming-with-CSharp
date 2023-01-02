
internal class Program
{
    private static void Main(string[] args)
    {
        string polynomial1 = "(3x2 + x - 3)";
        string polynomial2 = "(x - 1)";
        string polynomial3 = "(-7x2 + 5x - 17)";
        string polynomial4 = "(-x2 + 7)";
        string polynomial5 = "(9x3)";
        Polynomial polynomial = new Polynomial();

        string sum = polynomial.Sum(polynomial1, polynomial2);
        Console.WriteLine($"{polynomial1} + {polynomial2} = {sum}.");
        sum = polynomial.Sum(polynomial1, polynomial3);
        Console.WriteLine($"{polynomial1} + {polynomial3} = {sum}.");
        sum = polynomial.Sum(polynomial1, polynomial4);
        Console.WriteLine($"{polynomial1} + {polynomial4} = {sum}.");
        sum = polynomial.Sum(polynomial2, polynomial3);
        Console.WriteLine($"{polynomial2} + {polynomial3} = {sum}.");
        sum = polynomial.Sum(polynomial2, polynomial4);
        Console.WriteLine($"{polynomial2} + {polynomial4} = {sum}.");
        sum = polynomial.Sum(polynomial2, polynomial5);
        Console.WriteLine($"{polynomial2} + {polynomial5} = {sum}.");
        sum = polynomial.Sum(polynomial3, polynomial4);
        Console.WriteLine($"{polynomial3} + {polynomial4} = {sum}.");
        sum = polynomial.Sum(polynomial3, polynomial5);
        Console.WriteLine($"{polynomial3} + {polynomial5} = {sum}.");
        sum = polynomial.Sum(polynomial4, polynomial5);
        Console.WriteLine($"{polynomial4} + {polynomial5} = {sum}.");
    }
}