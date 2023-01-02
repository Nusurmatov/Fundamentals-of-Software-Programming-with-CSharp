public class Phone
{
    public enum Manufacturers { Apple, Huawei, LG, Nokia, RedMi, Samsung }

    private static Phone nokiaN95;
    
    public static Phone NokiaN95 { get { return nokiaN95; } }
    public GSM GSM { get; private set; } 
    public Battery Battery { get; private set; } 
    public Display Display { get; private set; }
    public PhoneNumber PhoneNumber { get; private set; } = new PhoneNumber();

    static Phone()
    {
        GSM gsmNokiaN95 = new GSM(Phone.Manufacturers.Nokia, "Nokia N95", 99);
        Battery batteryNokiaN95 = new Battery(Battery.BatteryType.LiIon);
        Display displayNokiaN95 = new Display("99 x 53 x 21 mm", "Silver");
        nokiaN95 = new Phone(gsmNokiaN95, batteryNokiaN95, displayNokiaN95);
    }

    public Phone() : this(new GSM(), new Battery(), new Display()) { } 
    public Phone(GSM gsm) : this(gsm, new Battery(), new Display()) { }
    public Phone(GSM gsm, Battery battery) : this(gsm, battery, new Display()) { }
    public Phone(GSM gsm, Battery battery, Display display)
    {
        this.GSM = gsm;
        this.Battery = battery;
        this.Display = display;
    } 
    
    public static void GetNokiaN95Info()
    {
        Console.WriteLine("Information about Nokia N95:");
        NokiaN95.GSM.GetInfo();
        NokiaN95.Battery.GetInfo();
        NokiaN95.Display.GetInfo();
    }

    public void GetInfo()
    {
        GSM.GetInfo();
        Battery.GetInfo();
        Display.GetInfo();
    }

    public void SetPhoneNumber(string tel)
    {
        try
        {
            this.PhoneNumber = new PhoneNumber(tel[..4], int.Parse(tel[4..6]), int.Parse(tel[6..]));
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid phone number...!");
        }
    }

    public void SetPhoneNumber(string countryCode, int areaCode, int number)
    {
        this.PhoneNumber = new PhoneNumber(countryCode, areaCode, number);
    }

    public override string ToString()
    {
        return $"{GSM.Manufacturer}, {GSM.Model} owned by {GSM.Owner}.";
    }
}