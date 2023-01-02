// (Difficult) Ex8,9,10,11,12,13,14,15,16,17,18,19:

public class Test
{
    private static Random generator = new Random();
    private static Phone MyPhone { get; set; }

    static Test()
    {
        MyPhone = new Phone();
    }

    private static void Main()
    {   
        Console.Clear();
        TestPhone();
        TestCallClass();
    }

    private static void TestPhone()
    {
        SetBackground("Phone, GSM, Battery and Display classes", front: ConsoleColor.Magenta, back: ConsoleColor.Black);
        Phone.GetNokiaN95Info();
        Console.WriteLine();

        GSM gsmGalaxyA10s = new GSM(Phone.Manufacturers.Samsung, "Galaxy A10s");
        gsmGalaxyA10s.Owner = "Nusurmatov Khusniddin";
        var batteryGalaxyA10s = new Battery(Battery.BatteryType.LiPol);
        var displayGalaxyA10s = new Display("75.8 x 156.9 x 7.8 mm", "Black"); 
        Console.WriteLine("{0}\n{1}\n{2}\n", gsmGalaxyA10s, batteryGalaxyA10s, displayGalaxyA10s);
        
        Phone galaxyA10s = new Phone(gsmGalaxyA10s, batteryGalaxyA10s, displayGalaxyA10s);
        galaxyA10s.GetInfo();
        galaxyA10s.SetPhoneNumber("+998993981302");
        Console.WriteLine("Phone Number: {0}\n\n", galaxyA10s.PhoneNumber);
        MyPhone = galaxyA10s;
    }

    private static void TestCallClass()
    {
        string text = "GetCallHistory, DeleteCall, DeleteAllCallHistory, CalculateAllCalls and CallSomebody methods";
        SetBackground(text, front: ConsoleColor.DarkCyan, back: ConsoleColor.Black);

        string[] names = { "Jahongir", "Diyor", "Zaynobiddin", "Rahmiddin", "Abdurauf", "Jasur", "Sardor" };

        foreach (var name in names)  // Calling to seven friends
        {
            MyPhone.GSM.CallSomebody(name, (Call.TypeOfCall) generator.Next(3));
        }

        Console.WriteLine("Complete Call History: \n{0}", MyPhone.GSM.GetCallHistory());

        Console.WriteLine("Assuming call costs 0.37$ per minute, All calls cost: {0}$", MyPhone.GSM.CalculateAllCalls(0.37m));  
        
        TimeSpan longestCall = MyPhone.GSM.GetLongestCall().Duration;
        string nameToBeDeleted = MyPhone.GSM.GetLongestCall().Called; 
        Console.WriteLine("Deleting {0} from the Call History Archive...", nameToBeDeleted);
        MyPhone.GSM.DeleteCall(nameToBeDeleted);
      
        Console.WriteLine("Now, Call History: \n{0}", MyPhone.GSM.GetCallHistory());
        Console.WriteLine("Now, All calls cost: {0}$", MyPhone.GSM.CalculateAllCalls(0.37m));  

        Console.WriteLine("Deleting All Calls...");
        MyPhone.GSM.DeleteAllCallHistory();
        Console.WriteLine("Now, Call History Archive: {0}", MyPhone.GSM.GetCallHistory());
    }   

    private static void SetBackground( string text, ConsoleColor front = ConsoleColor.DarkCyan, ConsoleColor back = ConsoleColor.White)
    {
        Console.BackgroundColor = back;
        Console.ForegroundColor = front;
        Console.WriteLine($" ------------     Testing {text}...      ------------\n");
    }
}

/* Output:
 ------------     Testing Phone, GSM, Battery and Display classes...      ------------

Information about Nokia N95:
Manufacturer: Nokia
Model: Nokia N95
Owner: Unknown
Price: $99.00
Battery Model: LiIon
Display Size: 99 x 53 x 21 mm
Display Color: Silver

Samsung, Galaxy A10s - $68.00 owned by Nusurmatov Khusniddin.
Battery Type - LiPol, Total Hours Talk - 00:00:00.
75.8 x 156.9 x 7.8 mm, Black.

Manufacturer: Samsung
Model: Galaxy A10s
Owner: Nusurmatov Khusniddin
Price: $68.00
Battery Model: LiPol
Display Size: 75.8 x 156.9 x 7.8 mm
Display Color: Black
Phone Number: +99899 398 13 02


 ------------     Testing GetCallHistory, DeleteCall, DeleteAllCallHistory, CalculateAllCalls and CallSomebody methods...      ------------

Complete Call History:
1. Jasur, Missed call, started: Wednesday, August 19, 2020 16:33:44, duration: 2 minutes and 14 secunds.
2. Sardor, Incoming call, started: Tuesday, October 6, 2020 03:11:52, duration: 1 minutes and 15 secunds.
3. Zaynobiddin, Outgoing call, started: Tuesday, October 13, 2020 15:32:24, duration: 1 minutes and 22 secunds.
4. Jahongir, Incoming call, started: Thursday, July 22, 2021 18:24:49, duration: 4 minutes and 24 secunds.
5. Rahmiddin, Incoming call, started: Monday, August 2, 2021 05:28:35, duration: 4 minutes and 43 secunds.
6. Diyor, Outgoing call, started: Friday, October 7, 2022 04:17:32, duration: 3 minutes and 0 secunds.
7. Abdurauf, Missed call, started: Tuesday, October 11, 2022 22:30:00, duration: 4 minutes and 9 secunds.

Assuming call costs 0.37$ per minute, All calls cost: 7.03$
Deleting Rahmiddin from the Call History Archive...
Now, Call History:
1. Jasur, Missed call, started: Wednesday, August 19, 2020 16:33:44, duration: 2 minutes and 14 secunds.
2. Sardor, Incoming call, started: Tuesday, October 6, 2020 03:11:52, duration: 1 minutes and 15 secunds.
3. Zaynobiddin, Outgoing call, started: Tuesday, October 13, 2020 15:32:24, duration: 1 minutes and 22 secunds.
4. Jahongir, Incoming call, started: Thursday, July 22, 2021 18:24:49, duration: 4 minutes and 24 secunds.
5. Diyor, Outgoing call, started: Friday, October 7, 2022 04:17:32, duration: 3 minutes and 0 secunds.
6. Abdurauf, Missed call, started: Tuesday, October 11, 2022 22:30:00, duration: 4 minutes and 9 secunds.

Now, All calls cost: 5.55$
Deleting All Calls...
Now, Call History Archive: Empty...
*/