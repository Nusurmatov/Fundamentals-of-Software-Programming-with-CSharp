public class CaseInsensitiveComparer : IComparer<string>
{
    public int Compare(string? x, string? y) => string.Compare(x, y, ignoreCase: true);
}