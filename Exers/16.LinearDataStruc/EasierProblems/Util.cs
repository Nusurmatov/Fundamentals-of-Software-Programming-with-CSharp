public static class Util
{
    public static Random Random = new Random();

    public static void PrintIEnumerable<T>(IEnumerable<T> items)
    {
        Console.Write("{ ");
        foreach (var item in items)
        {
            Console.Write($"{item} ");
        }
        Console.Write("}");
    }
        
    public static List<int> GenerateRandomList(int length, int lowerBound, int upperBound)
    {
        var result = new List<int>();

        for (int i = 0; i < length; i++)
        {
            result.Add(Random.Next(lowerBound, upperBound));
        }

        return result;
    }    
}
