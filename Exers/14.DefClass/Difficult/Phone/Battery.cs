public class Battery
{
    public enum BatteryType { LiIon, LiPol, NiCd, NiMH, NonOEM, OEM }

    private static Random generator = new Random();
    public BatteryType Model { get; private set; }
    public TimeSpan IdleTime { get; private set; }
    
    // private bool IdleMode = true;
    public TimeSpan TotalHoursTalk { get; private set; } 

    public Battery() : this((BatteryType) generator.Next(6)) { }

    public Battery(BatteryType model)
    {
        this.Model = model;
    }

    public void GetInfo()
    {
        Console.WriteLine("Battery Model: {0}", Model);
    }

    public override string ToString()
    {
        return $"Battery Type - {Model}, Total Hours Talk - {TotalHoursTalk}.";
    }
}