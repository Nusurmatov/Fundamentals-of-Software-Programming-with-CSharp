/* (Easier) Ex23 - Problems Statement:
Write a program that reads a string from the console and prints in
alphabetical order all words from the input string and how many
times each one of them occurs in the string.
*/

Console.Write("Enter a small text: ");
string text = Console.ReadLine() ?? String.Empty;

var words = new Dictionary<string, int>();
foreach (var word in text.Split(" ", StringSplitOptions.RemoveEmptyEntries))
{   
    string copy = word;
    char lastChar = word[^1];
    if (lastChar == '.' || lastChar == '!' || lastChar == '?' || lastChar == ')' || lastChar == '"')
    {
        copy = word.Replace(lastChar.ToString(), "");
    }

    if (words.ContainsKey(copy))
    {
        words[copy]++;
    }
    else
    {
        words[copy] = 1;
    }

    
}

/* Output:
Enter a string of maximum length 20: Hello
Hello***************
*/