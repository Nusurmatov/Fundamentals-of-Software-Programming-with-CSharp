using System.Diagnostics;

public class OutputUtil
{
    public static void LogToFile(string log, bool isAppend = false, bool isOneLine = false)
    {
        var frame = new StackFrame(1);
        string filepath = Path.Combine("Outputs", 
            $"{frame.GetMethod().DeclaringType.Name}-{frame.GetMethod()}.txt");

        using(var writer = new StreamWriter(filepath, isAppend))
        {
            if (isOneLine)
            {
                writer.Write(log);
            }
            else
            {
                writer.WriteLine(log);
            }
        }
    }
}