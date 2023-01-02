public class Call
{
    public enum TypeOfCall { Outgoing, Incoming, Missed }

    protected TypeOfCall CallType { get; set; }
    protected DateTime EndTime { get; set; }
    protected DateTime StartTime { get; set; }
    public TimeSpan Duration { get; set; }
    public string Called { get; set; } = String.Empty;
    private static Random generator = new Random(); 

    public List<Call> CallHistory { get; private set; } = new List<Call>();
    private int CallCounter { get; set; } = 0;

    private Call LongestCall { get; set; }

    public virtual void CallSomebody(string name, TypeOfCall type)
    { 
        CallHistory.Add(new Call());
        CallHistory[CallCounter].StartTime = GetRandomDate();
        CallHistory[CallCounter].Called = name;
        CallHistory[CallCounter].CallType = type;
        CallHistory[CallCounter].EndTime = CallHistory[CallCounter].StartTime.AddSeconds(generator.Next(30, 300));
        CallHistory[CallCounter].Duration = CallHistory[CallCounter].EndTime - CallHistory[CallCounter].StartTime;
        CallCounter++;
    }

    public virtual void DeleteCall(string name)
    {
        for (int i = 0; i < this.CallCounter; i++)
        {
            if (this.CallHistory[i].Called == name)
            {
                this.CallHistory.Remove(this.CallHistory[i]);
                break;
            }
        }

        this.CallCounter--;
    }

    public virtual void DeleteAllCallHistory()
    {
        this.CallHistory.Clear();
        this.CallCounter = 0;
    }

    public virtual string CalculateAllCalls(decimal price)
    {
        decimal result = 0.0m;

        foreach (var call in this.CallHistory)
        {
            result += call.Duration.Minutes * price;
        }
        
        return result.ToString();
    }

    public virtual string GetCallHistory()
    {
        var result = new System.Text.StringBuilder();
        int counter = 1;

        if (this.CallCounter == 0)
        {
            result.Append("Empty...");
        }
        else
        {
            var query = from call in this.CallHistory
                        orderby call.StartTime
                        select call;
            this.CallHistory = query.ToList(); 
            
            foreach (var call in this.CallHistory)
            {
                result.Append($"{counter}. {call.Called}, ");
                result.Append($"{call.CallType} call, ");
                result.Append($"started: {call.StartTime.ToString("F")}, ");
                result.Append($"duration: {call.Duration.Minutes} minutes and {call.Duration.Seconds} secunds.\n");
                counter++;
            }
        }

        return result.ToString();
    }

    public virtual Call GetLongestCall()
    {
        TimeSpan max = TimeSpan.Zero;
        LongestCall = new Call();

        foreach (var call in CallHistory)
        {
            if (call.Duration > max)
            {
                max = call.Duration;
                this.LongestCall.Called = call.Called;
            }
        }

        this.LongestCall.Duration = max;

        return LongestCall;
    }

    private static DateTime GetRandomDate()
    {
        string randomDay = generator.Next(1, 29).ToString();
        string randomMonth = generator.Next(1, 13).ToString();
        string randomYear = generator.Next(2020, 2023).ToString();
        string randomHour = generator.Next(24).ToString();
        string randomMinute = generator.Next(60).ToString();
        string randomSecond = generator.Next(60).ToString();

        var randomDate = new System.Text.StringBuilder();
        randomDate.Append($"{randomMonth}/{randomDay}/{randomYear} ");
        randomDate.Append($"{randomHour}:{randomMinute}:{randomSecond}");

        return DateTime.Parse(randomDate.ToString());
    }
}