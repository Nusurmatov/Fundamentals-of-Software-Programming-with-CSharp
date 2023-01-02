// Ex5 - Editing a Subtitle File:

const double COEFFICIENT = 1.05;
const int ADDITION = 5000;
const string INPUT_FILE = "ex5Bad.txt";
const string OUTPUT_FILE = "ex5Fixed.txt";
const char OPENING_BRACKET = '{';
const char CLOSING_BRACKET = '}';

try
{
    // Create reader
    StreamReader streamReader = new StreamReader(INPUT_FILE);

    // Create writer
    StreamWriter streamWriter = new StreamWriter(OUTPUT_FILE, false);
    using (streamReader)
    {
        using (streamWriter)
        {
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                streamWriter.WriteLine(FixLine(line));
            }
        }
    }

    PrintFile(INPUT_FILE);
    PrintFile(OUTPUT_FILE);
}
catch (IOException exc)
{
    Console.WriteLine("Error: {0}.", exc.Message);
}

string FixLine(string line)
{
    // Find closing brace
    int bracketFromIndex = line.IndexOf('}');
 
    // Extract 'from' time
    string fromTime = line.Substring(1, bracketFromIndex - 1);

    // Calculate new 'from' time
    int newFromTime = (int) (Convert.ToInt32(fromTime) * COEFFICIENT + ADDITION);

    // Find the following closing brace
    int bracketToIndex = line.IndexOf('}', bracketFromIndex + 1);

    // Extract 'to' time
    string toTime = line.Substring(bracketFromIndex + 2, bracketToIndex - bracketFromIndex - 2);

    // Calculate new 'to' time
    int newToTime = (int) (Convert.ToInt32(toTime) * COEFFICIENT + ADDITION);

    // Create a new line using the new 'from' and 'to' times
    var fixedLine = new System.Text.StringBuilder();
    fixedLine.Append($"{OPENING_BRACKET}{newFromTime}{CLOSING_BRACKET}");
    fixedLine.Append($"{OPENING_BRACKET}{newToTime}{CLOSING_BRACKET}");
    fixedLine.Append(line.Substring(bracketToIndex + 1));
    
    return fixedLine.ToString();
}

void PrintFile(string fileName)
{
    Console.WriteLine("------------  {0}  ------------", fileName);
    
    try
    {
        using (var reader = new StreamReader(fileName))
        {
            string text = reader.ReadToEnd();
            Console.WriteLine($"{text}\n");
        }        
    }
    catch (IOException e)
    {
        Console.WriteLine(e.Message);        
    }
}   

/* Output:
------------  ex5Bad.txt  ------------
{1029}{1122}{Y:i}I'll never join you.
{1123}{1270}{Y:i}If you only knew | the power of the dark side.      
{1343}{1468}{Y:i}Obi One never told you what happened to your father!
{1509}{1610}{Y:i}He told me enough! | He told me you killed him.     
{1632}{1718}{Y:i}No... I am your father!
{1756}{1820}(dramatic music playing)...
{1821}{1938}No, no that's not true... | That's impossible!
{1942}{1992}Search your feelings,| you know it's true.
{3104}{3228}{Y:b}Nooo.

------------  ex5Fixed.txt  ------------
{6080}{6178}{Y:i}I'll never join you.
{6179}{6333}{Y:i}If you only knew | the power of the dark side.      
{6410}{6541}{Y:i}Obi One never told you what happened to your father!
{6584}{6690}{Y:i}He told me enough! | He told me you killed him.     
{6713}{6803}{Y:i}No... I am your father!
{6843}{6911}(dramatic music playing)...
{6912}{7034}No, no that's not true... | That's impossible!
{7039}{7091}Search your feelings,| you know it's true.
{8259}{8389}{Y:b}Nooo.
*/