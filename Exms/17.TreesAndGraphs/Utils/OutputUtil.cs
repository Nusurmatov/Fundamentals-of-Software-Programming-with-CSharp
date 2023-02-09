using System.Diagnostics;

public class OutputUtil
{
    public static void LogToFile(string log)
    {
        var frame = new StackFrame(1);
        string filepath = Path.Combine("Outputs", $"{frame.GetMethod().DeclaringType.Name}.txt");

        using(var writer = new StreamWriter(filepath, append: true))
        {
            writer.Write(log);
        }
    }
}