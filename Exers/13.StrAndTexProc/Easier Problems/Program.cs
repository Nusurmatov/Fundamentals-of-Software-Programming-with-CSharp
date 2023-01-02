/* (Easier) Ex25 - Problems Statement:
 Write a program that reads a list of words separated by commas from the
console and prints them in alphabetical order (after sorting).
*/

Console.Write("Enter words seperated by only commas: ");
string str = Console.ReadLine() ?? String.Empty;
str = str.Replace(" ", String.Empty);
string[] words = str.Split(',');
Array.Sort(words);

Console.WriteLine("After Sorting:");
foreach (var word in words)
{
    Console.WriteLine(word);
}

/* Output:
Enter words seperated by only commas: apple,banana,melon,apricot,pomegrante, cucumber 
After Sorting:
apple
apricot       
banana        
cucumber      
melon
pomegrante 
*/