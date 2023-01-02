/* (Difficult) Ex12 - Problem Statement:
Write a program to download a file from Internet by given URL, e.g.
http://introprogramming.info/wp-content/themes/introprograming_en/
images/Intro-Csharp-Book-front-cover-big_en.png.
*/

using System.Net;

string url = "https://github.com/SoftUni/Programming-Basics-Book-CSharp-EN/blob/master/resources/Programming-Basics-CSharp-Book-and-Video-Lessons-Nakov-v2019.epub?raw=true.";
string destination = @"C:\Users\Xusniddin\Desktop\Khusniddin\C#.epub";

try
{
   using (var client = new WebClient())
   {
      client.DownloadFile(url, destination);
   }
   Console.WriteLine("Successfully downloaded at {0}.", destination);
}
catch (ArgumentException e)
{
   Console.WriteLine(e.Message);
}
catch (WebException e)
{
   Console.WriteLine(e.Message);
}
catch (NotSupportedException e)
{
   Console.WriteLine(e.Message);
}

/* Output:
Successfully downloaded at C:\Users\Xusniddin\Desktop\Khusniddin\C#.epub.
*/