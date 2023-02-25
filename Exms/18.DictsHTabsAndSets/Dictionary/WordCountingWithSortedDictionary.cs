public class WordCountingWithSortedDictionary
{
    public static IDictionary<string, int> GetWordOccuranceMap(string text, bool IsCaseInSensitive = false)
    {
        string[] tokens = text.Split(' ', '.', ',', '-', '?', '!', '\n', '\t');
        IDictionary<string, int> words = !IsCaseInSensitive ? new SortedDictionary<string, int>() 
            : new SortedDictionary<string, int>(new CaseInsensitiveComparer());

        foreach (var word in tokens)
        {
            if (!string.IsNullOrEmpty(word.Trim()))
            {
                int count;
                if (!words.TryGetValue(word, out count))
                {
                    count = 0;
                }
                words[word] = count + 1;
            }
        }
        
        return words;
    }

    public static void PrintWordOccuranceCount(IDictionary<string, int> wordOccuranceMap)    
    {
        foreach (var wordEntry in wordOccuranceMap)
        {
            Console.Write($"Word '{wordEntry.Key}' occures {wordEntry.Value} time");
            Console.Write(wordEntry.Value != 1 ?  "s" : "");
            Console.WriteLine(" in the text");
        }
    }
}