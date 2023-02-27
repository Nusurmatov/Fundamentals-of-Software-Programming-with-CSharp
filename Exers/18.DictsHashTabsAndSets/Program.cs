/* Easier Problems, Ex3 - Problem Statement:
Write a program that counts how many times each word from a given text file words.txt appears in it. 
The result words should be ordered by their number of occurrences in the text.
Example: "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?"
Result: is -> 2, the -> 2, this -> 3, text -> 6.
*/

void PrintDictioinary(IOrderedEnumerable<KeyValuePair<string, int>> dictionary)
{
    foreach (var item in dictionary)
    {
        Console.Write($"{item.Key} -> {item.Value} time");
        Console.WriteLine(item.Value > 1 ? "s" : string.Empty);
    }
}

Dictionary<string, int> GetOccurancesOfArrayElements(string text)
{
    var result = new Dictionary<string, int>();
    var tokens = new char[] {',', ' ', '?', '.', '.', '–', '!'};
    var array = text.ToLowerInvariant().Split(tokens);

    foreach (var item in array)
    {
        if (!string.IsNullOrEmpty(item))
        {
            var key = item.Trim();
            if (result.Keys.Contains(key))
            {
                result[key]++;
            }
            else
            {
                result[key] = 1;
            }
        }
    }

    return result;
}

void RemoveArrayElements(ref int[] array, Dictionary<int, int> dictionary, bool removeOdd = true)
{
    var result = new List<int>();

    foreach (var num in array)
    {
        if (removeOdd && dictionary[num] % 2 == 0)
        {
            result.Add(num);
        }
        
        if (removeOdd == false && dictionary[num] % 2 == 1)
        {
            result.Add(num);
        }
    }
    
    array = result.ToArray();
}

var path = Path.Combine("Easier", "exe3.txt");
var text = File.ReadAllText(path);
Console.WriteLine(text);
var occuranceMap = GetOccurancesOfArrayElements(text);
var sorted = occuranceMap.OrderBy(p => p.Value);
PrintDictioinary(sorted);

/* Output: 
This is the TEXT. Text, text, text - THIS TEXT! Is this the text?
is -> 2 times  
the -> 2 times 
this -> 3 times
text -> 6 times
*/