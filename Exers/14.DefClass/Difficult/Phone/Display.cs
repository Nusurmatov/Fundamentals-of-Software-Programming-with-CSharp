public class Display
{
    private const string defaultValue = "Unknown";
    public string Size { get; private set; }
    public string Color { get; private set; }

    public Display(string size = defaultValue, string color = defaultValue)
    {
        this.Size = size;
        this.Color = color;    
    }

    public void GetInfo()
    {
        Console.WriteLine("Display Size: {0}", Size);
        Console.WriteLine("Display Color: {0}", Color);
    }

    public override string ToString()
    {
        return $"{Size}, {Color}.";
    }
}