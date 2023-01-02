/* Ex11 - Formatting Strings:
More information about formatting strings can be found on the Internet and in the 
Composite Formatting article in MSDN (http://msdn.microsoft.com/en-us/library/txafckwd.aspx).
*/

using System.Globalization;

DateTime date = DateTime.Now;
string name = "David Scott";
string task = "Introduction to C# book";
string location = "his office";
string formattedText = String.Format("Today is {0:MM/dd/yyyy} and {1} is working on {2} in {3}.",
date, name, task, location);
Console.WriteLine(formattedText);

string text = "11/12/2001";
string format = "MM/dd/yyyy";
DateTime parsedDate = DateTime.ParseExact(text, format, CultureInfo.InvariantCulture);
Console.WriteLine("Day: {0}\nMonth: {1}\nYear: {2}", parsedDate.Day, parsedDate.Month, parsedDate.Year);

/* Output:
Today is 08-12-2022 and David Scott is working on Introduction to C# book in his office.
Day: 12   
Month: 11 
Year: 2001
*/