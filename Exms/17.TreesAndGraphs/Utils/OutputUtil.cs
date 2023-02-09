using System.Diagnostics;

public class OutputUtil
{
    public static void LogToFile(string log, bool isAppend = false)
    {
        var frame = new StackFrame(1);
        string filepath = Path.Combine("Outputs", $"{frame.GetMethod().DeclaringType.Name}.txt");

        using(var writer = new StreamWriter(filepath, isAppend))
        {
            writer.WriteLine(log);
        }
    }
}