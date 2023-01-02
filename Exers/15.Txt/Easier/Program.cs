/* Ex10 - Problem Statement:
Write a program that extracts from an XML file the text only (without the
tags). Sample input file:
<?xml version="1.0"><student><name>Peter</name>
<age>21</age><interests count="3"><interest>
Games</interest><interest>C#</interest><interest>
Java</interest></interests></student>
Sample output:
Peter
21
Games
C#
Java
*/

try
{
    Console.Clear();
    string fileName = "ex10.txt";
    var words = new System.Text.StringBuilder();

    PrintFileContent(fileName);

    using (StreamReader reader = new StreamReader(fileName))
    {
        int charac = reader.Read();
        while (charac != -1)
        {
            if (charac == 62)  // '>' in ASCII
            {
                charac = reader.Read();
                if (charac != 60)  // '<' in ASCII
                {
                    while (charac != 60 && charac != -1)
                    {
                        words.Append(((char) charac).ToString());
                        charac = reader.Read();
                    }
                    words.Append("\n");
                }
            }

            charac = reader.Read();                
        }
    }
    
    Console.WriteLine("Extracted words:");
    foreach (var word in words.ToString().Split('\n', StringSplitOptions.RemoveEmptyEntries))
    {
        if (word.Length != 1)
        {
            Console.WriteLine(word);
        }
    }
}
catch (FileNotFoundException e)
{
    Console.WriteLine(e.Message);
}
catch (DirectoryNotFoundException e)
{
    Console.WriteLine(e.Message);
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}

/* Output:
------------  ex10.txt  ------------
<?xml version="1.0"><student><name>Peter</name>
<age>21</age><interests count="3"><interest>
Games</interest><interest>C#</interest><interest>
Java</interest></interests></student>

Extracted words:
Peter
21
Games
C#
Java
*/

string GetFileContent(string fileName)
{
    string text = String.Empty;
    try
    {
        using (var reader = new StreamReader(fileName))
        {
            text = reader.ReadToEnd();
        }        
    }
    catch (IOException e)
    {
        Console.WriteLine(e.Message);        
    }

    return text;
}

void PrintFileContent(string fileName)
{
    Console.WriteLine("------------  {0}  ------------", fileName);
    
        string text = GetFileContent(fileName);
        Console.WriteLine($"{text}\n");
}   