public class Start
{
    public static void LinqPractice()
    {
        // Mapping and Ordering:
        Console.Clear();
        MathOperations();        
        ConvertingCollections();
        SortingCollecttions();
        LambdaAndLinq();
    }

    private static void MathOperations()
    {
        Console.Write("Enter sequence of numbers seperated with one space: ");
        string? input = Console.ReadLine()?.Trim(); 
        if (string.IsNullOrEmpty(input))
        {
            input = GenerateSequencOfNumbers();   
        }

        List<double> numList = input.Split()
                                    .Select(double.Parse)
                                    .ToList() ?? GenerateList();

        // Math operations: Min, Max, Sum, Average
        WriteBeutifiedBlockTitle("Math Operations");

        Console.WriteLine("Number list: {0}", string.Join(", ", numList));
        Console.WriteLine($"Min -> {numList.Min()}");
        Console.WriteLine($"Max -> {numList.Max()}");
        Console.WriteLine($"Sum -> {numList.Sum()}");
        Console.WriteLine($"Average -> {numList.Average():0.##}");
    }

    private static void ConvertingCollections()
    {
        // Converting Collections: ToArray, ToCharArray, ToDictionary
        WriteBeutifiedBlockTitle("Converting Collections");
        
        string[] fullNames = {"Nusurmatov Husniddin", "Inomjonov Jahongir"};
        Console.WriteLine("Fullnames array: {0}", string.Join(", ", fullNames));
        
        string[] names = fullNames.Select(x => x.Split()[0]).ToArray();
        Console.WriteLine("Only surnames: {0}", string.Join(", ", names));
        
        char[] spelledSurname = names.Last().ToCharArray();
        Console.WriteLine("Spelled surname: {0}", string.Join(", ", spelledSurname));

        var dict = fullNames.Select(x => x.Split())
                            .ToDictionary(p => p.First(), 
                                          p => p.Last());
        Console.WriteLine("Surname and Name: {0}", string.Join(", ", dict));
    }

    private static void SortingCollecttions()
    {
        // Sorting Collections: OrderBy, ThenBy, Take, Skip
        WriteBeutifiedBlockTitle("Sorting Collections");

        var nums = new List <int> { 5, 7, 10, -5}; 
        Console.WriteLine("Number list (ascending): {0}", string.Join(", ", nums.OrderBy(x => x)));
        Console.WriteLine("Number list (descending): {0}", string.Join(", ", nums.OrderByDescending(x => x)));

        var strNums = new List <string> { "5", "7", "10", "-5"}; 
        Console.WriteLine("String number list (ascending): {0}", string.Join(", ", nums.OrderBy(x => x)));
        Console.WriteLine("String number list (descending): {0}\n", string.Join(", ", nums.OrderByDescending(x => x)));

        var products = new Dictionary<int, string>() {
            { 63, "Door" },
            { 700, "Brick" },
            { 629, "Door" },
            { 78, "Wallpaper" },
        };
        Console.WriteLine("Products: {0}", string.Join(", ", products));
   
        var orderedProducts = products.OrderBy(pair => pair.Value)
                                      .ThenBy(pair => pair.Key)
                                      .ToDictionary(pair => pair.Key, 
                                                    pair => pair.Value);
        Console.WriteLine("Ordered products: {0}\n", string.Join(", ", orderedProducts));

        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7};
        Console.WriteLine("Number list: {0}", string.Join(", ", numbers));

        Console.WriteLine("First three: {0}", string.Join(", ", numbers.Take(3)));
        Console.WriteLine("Last two: {0}", string.Join(", ", numbers.TakeLast(2)));

        Console.WriteLine("Middle two: {0}", string.Join(", ", numbers.Skip(2).Take(2)));
        Console.WriteLine("Greater than two less than six: {0}", 
            string.Join(", ", numbers.SkipWhile(x => x < 3).TakeWhile(x => x < 6)));
    }                                                                                            

    private static void LambdaAndLinq()
    {
        // Lambda and Linq: Lambda Function/Expression, Where, Count, Select, Distinct, First, Last, Single, Reverse
        WriteBeutifiedBlockTitle("Lambda and Linq");
    }

    private static List<double> GenerateList(int size = 7, int lowerBound = -100, int upperBound = 100)
    {
        var result = new List<double>(); 
        var random = new Random();

        for (int i = 0; i < size; i++)
        {
            result.Add(random.Next(lowerBound, upperBound) / random.Next(1, 11));
        }

        return result;
    }

    private static string GenerateSequencOfNumbers() => string.Join(" ", GenerateList());

    private static void WriteBeutifiedBlockTitle(string title, char symbol = '-', int pad = 10)
    {
        Console.WriteLine($"\n{"".PadLeft(pad, symbol)} {title} {"".PadLeft(pad, symbol)}");
    }
}
