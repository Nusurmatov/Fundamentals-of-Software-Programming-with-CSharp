public static class Traverser
{
    public static void TraverseBFS(this string directoryPath)
    {
        var visitedDirectories = new Queue<DirectoryInfo>();
        visitedDirectories.Enqueue(new DirectoryInfo(directoryPath));

        while (visitedDirectories.Any())
        {
            var currentDir = visitedDirectories.Dequeue();
            Console.WriteLine(currentDir.FullName);
            OutputUtil.LogToFile(currentDir.FullName);

            var children = currentDir.GetDirectories();
            foreach (var child in children)
            {
                visitedDirectories.Enqueue(child);
            }
        }
    }

    public static void TraverseDFS(this string directoryPath)
        => TraverseDFS(new DirectoryInfo(directoryPath), string.Empty);

    private static void TraverseDFS(DirectoryInfo dir, string spaces)
    {
        string output = $"{spaces}{dir.FullName}";
        Console.WriteLine(output);
        OutputUtil.LogToFile(output, isAppend: true);

        DirectoryInfo[] children = dir.GetDirectories();

        foreach (var child in children)
        {
            TraverseDFS(child, $"{spaces}  ");
        }
    }
}