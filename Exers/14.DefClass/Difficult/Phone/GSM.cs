public class GSM: Call
{
    private const string defaultValue = "Unknown";
    private static Random generator = new Random();
    public Phone.Manufacturers Manufacturer { get; private set; }
    public string Model { get; private set; }
    public string Owner { get; set; }
    public int Price { get; private set; }

    public GSM(): this((Phone.Manufacturers) generator.Next(6)) { }

    public GSM(Phone.Manufacturers manufacturer, string model = defaultValue, string owner = defaultValue)
        : this(manufacturer, model, owner, generator.Next(100, 900)*25/100) { }

    public GSM(Phone.Manufacturers manufacturer, string model, int price)
        : this(manufacturer, model, defaultValue, price) { }  

    public GSM(Phone.Manufacturers manufacturer, string model, string owner, int price)
    {
        this.Manufacturer = manufacturer;
        this.Model = model;
        this.Owner = owner;
        this.Price = price;
        _ = new Call();
    }

    public void GetInfo()
    {
        Console.WriteLine("Manufacturer: {0}", Manufacturer);
        Console.WriteLine("Model: {0}", Model);
        Console.WriteLine("Owner: {0}", Owner);
        Console.WriteLine("Price: {0:C2}", Price);
    }

    public void ChangePrice(int priceChange)
    {
        if (Price + priceChange < 0)
        {
            throw new ArgumentException("Price cannot be lower than ZERO...!");
        }

        Price += priceChange; 
    }

    public override string ToString()
    {
        return $"{Manufacturer}, {Model} - {Price:C2} owned by {Owner}.";
    }
}