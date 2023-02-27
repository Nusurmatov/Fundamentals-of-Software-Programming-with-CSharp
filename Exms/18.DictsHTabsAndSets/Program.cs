void DictionaryExample()
{
    var text = "Mary had a little lamb " +
            "little Lamb, little Lamb, " + 
            "Mary had a Little lamb, " +
            "whose fleece were white as snow.";

    Console.WriteLine($"{text}\n");
    Console.Write("Enter for 1 to be case-insensitive, otherwise it will be case-sensative: ");
    var input = Console.ReadKey();
    Console.WriteLine();
    bool isCaseInSensitive = input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1 ? true : false;

    IDictionary<string, int> wordOccuranceMap 
        = WordCountingWithSortedDictionary.GetWordOccuranceMap(text, isCaseInSensitive);
    WordCountingWithSortedDictionary.PrintWordOccuranceCount(wordOccuranceMap);
    WaitKey();
}

void HashTableExample()
{
    IEqualityComparer<Point3D> comparer = new Point3DEqualityComparer();
    Dictionary<Point3D, int> dict = new Dictionary<Point3D, int>(comparer);
    
    dict[new Point3D(4, 2, 5)] = 5;
    dict[new Point3D(1, 2, 3)] = 1;
    dict[new Point3D(3, 1, -1)] = 3;
    dict[new Point3D(1, 2, 3)] = 10;
    
    foreach (var entry in dict)
    {
        Console.WriteLine("{0} --> {1}", entry.Key, entry.Value);
    }

    WaitKey();
}

void SortedSetExample()
{
    SortedSet<string> bandsBradLikes = new SortedSet<string>(new[] {
            "Manowar", "Blind Guardian", "Dio", "Kiss",
            "Dream Theater", "Megadeth", "Judas Priest",
            "Kreator", "Iron Maiden", "Accept"
        });

    SortedSet<string> bandsAngelinaLikes = new SortedSet<string>(new[] {
            "Iron Maiden", "Dio", "Accept", "Manowar", "Slayer",
            "Megadeth", "Running Wild", "Grave Gigger", "Metallica"
        });

    Console.Write("Brad Pitt likes these bands: ");
    Console.WriteLine(string.Join(", ", bandsBradLikes));

    Console.Write("Angelina Jolie likes these bands: ");
    Console.WriteLine(string.Join(", ", bandsAngelinaLikes));

    SortedSet<string> intersectBands = new SortedSet<string>(bandsBradLikes);
    intersectBands.IntersectWith(bandsAngelinaLikes);
    Console.WriteLine(string.Format("Does Brad Pitt like Angelina Jolie? {0}", 
        intersectBands.Count >= 5 ? "Yes!" : "No!"));
    Console.Write( "Because Brad Pitt and Angelina Jolie both like: ");

    Console.WriteLine(string.Join(", ", intersectBands));
    SortedSet<string> unionBands = new SortedSet<string>(bandsBradLikes);
    unionBands.UnionWith(bandsAngelinaLikes);
    Console.Write("All bands that Brad Pitt or Angelina Jolie like: ");
    Console.WriteLine(string.Join(", ", unionBands));

    WaitKey();
}

void WaitKey()
{
    Console.Write("\nEnter any key to continue: ");
    Console.ReadKey();
    Console.Clear();
}

Start.LinqPractice();
WaitKey();

// DictionaryExample();
// HashTableExample();
// SortedSetExample();