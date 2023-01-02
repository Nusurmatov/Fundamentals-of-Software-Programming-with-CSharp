// Ex8 - Input Data Validation :

Console.WriteLine("What time is it?");
Console.Write("Hours: ");
int hours = int.Parse(Console.ReadLine() ?? "00");
Console.Write("Minutes: ");
int minutes = int.Parse(Console.ReadLine() ?? "00");

bool isValidTime = ValidateHours(hours) && ValidateMinutes(minutes);
if (isValidTime)
{
    Console.WriteLine("The time is {0:0#}:{1:0#} now.",
    hours, minutes);
}
else
{
    Console.WriteLine("Incorrect time!");
}

bool ValidateHours(int hours)
{
    bool result = (hours >= 0) && (hours < 24);
    return result;
}

bool ValidateMinutes(int minutes)
{
    bool result = (minutes >= 0) && (minutes <= 59);
    return result;
}

/* Input/Output:
What time is it?
Hours: 07
Minutes: 7
The time is 07:07 now.
*/