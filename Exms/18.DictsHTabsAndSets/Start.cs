public class Start
{
    public static void LinqPractice()
    {
        // Mapping and Ordering:
        List<double>? numList = GenerateIEnumerable();
        
        Console.Clear();
        Console.Write("Enter sequence of numbers seperated with one space: ");
        numList = Console.ReadLine()?.Split().Select(double.Parse).ToList();
        
        // Math operations: Min, Max, Sum, Average
        Console.WriteLine(string.Join(", ", numList));
        Console.WriteLine($"Min -> {numList.Min()}");
        Console.WriteLine($"Max -> {numList.Max()}");
        Console.WriteLine($"Sum -> {numList.Sum()}");
        Console.WriteLine($"Average ->f {numList.Average():0.##}\n");

        // Converting Collections:
        string[] fullNames = {"Nusurmatov Husniddin", "Inomjonov Jahongir"};
        Console.WriteLine(string.Join(", ", fullNames));
        string[] names = fullNames.Select(x => x.Split()[0]).ToArray();
                                                     // .Fisrt()    
        Console.WriteLine("Only surnames: {0}", string.Join(", ", names));
        char[] spelledSurname = names.Last().ToCharArray();
        Console.WriteLine("Spellecd surname: {0}", string.Join(", ", spelledSurname));

        Dictionary<string, string> dict = fullNames.ToDictionary(x => x.Split().First());
    
        // Sorting Collections: 
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
