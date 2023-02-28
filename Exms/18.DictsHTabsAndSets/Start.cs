public class Start
{
    public static void LinqPractice()
    {
        // Mapping and Ordering:
        List<double>? numList = GenerateIEnumerable();
        
        Console.Clear();
        Console.Write("Enter sequence of numbers seperated with one space: ");
        Console.WriteLine($"\n{"-".PadLeft(7)} Math Operations {"-".PadRight(7)}");
        numList = Console.ReadLine()?.Split().Select(double.Parse).ToList();
        
        // Math operations: Min, Max, Sum, Average
        Console.WriteLine(string.Join(", ", numList));
        Console.WriteLine($"Min -> {numList.Min()}");
        Console.WriteLine($"Max -> {numList.Max()}");
        Console.WriteLine($"Sum -> {numList.Sum()}");
        Console.WriteLine($"Average ->f {numList.Average():0.##}\n");

        // Converting Collections: ToArray, ToList, ToDictionary, ToCharArray
        string[] fullNames = {"Nusurmatov Husniddin", "Inomjonov Jahongir"};
        Console.WriteLine(string.Join(", ", fullNames));
        string[] names = fullNames.Select(x => x.Split()[0]).ToArray();
                                                     // .Fisrt()    
        Console.WriteLine("Only surnames: {0}", string.Join(", ", names));
        char[] spelledSurname = names.Last().ToCharArray();
        Console.WriteLine("Spellecd surname: {0}", string.Join(", ", spelledSurname));

        var dict = fullNames.Select(x => x.Split())
                            .ToDictionary(p => p.First(), p => p.Last());
        Console.WriteLine("Surname and Name: {0}\n", string.Join(", ", dict));
    
        // Sorting Collections: OrderBy, ThenBy
        var nums = new List <int> { 5, 7, 10, -5}; 
        var strNums = new List <string> { "5", "7", "10", "-5"}; 
        Console.WriteLine("Number list (ascending): {0}", string.Join(", ", nums.OrderBy(x => x)));
        Console.WriteLine("Number list (descending): {0}", string.Join(", ", nums.OrderByDescending(x => x)));
        Console.WriteLine("String number list (ascending): {0}", string.Join(", ", nums.OrderBy(x => x)));
        Console.WriteLine("String number list (descending): {0}\n", string.Join(", ", nums.OrderByDescending(x => x)));

        var products = new Dictionary<int, string>();

        var orderedProducts = products.OrderBy(pair => pair.Value)
                                      .ThenBy(pair => pair.Key)
                                      .ToDictionary(pair => pair.Key, pair => pair.Value);
    }

    private static List<double> GenerateIEnumerable(int size = 7, int lowerBound = -100, int upperBound = 100)
    {
        var result = new List<double>(); 
        var random = new Random();

        for (int i = 0; i < size; i++)
        {
            result.Add(random.Next(lowerBound, upperBound) / random.Next(1, 11));
        }

        return result;
    }
}
