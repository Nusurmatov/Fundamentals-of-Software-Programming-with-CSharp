/* Ex4 - Generate Random Password (Example):
To show you how useful the random numbers generator in .NET Framework can be, we are going to set as a
task to generate a random password which is between 8 and 15 characters long, contains at least two
capital letters, at least two small letters, at least one digit and at least three special chars. 
For this purpose we are going to use the following algorithm:
1. We start with an empty password. We create a generator of random numbers.
2. We generate twice a random capital letter and place it at a random position in the password.
3. We generate twice a random small letter and place it at a random position in the password.
4. We generate twice a random digit and place it at a random position in the password.
5. We generate three times a random special character and place it at a random position in the password.
6. Until this moment the password should consist of 8 characters. In orderto supplement it to 15 
   characters at most, we can insert random count of times (between 0 and 7) at a random position in the 
   password a random character (a capital letter, a small letter or a special char).
*/

using System.Text;

class RandomPasswordGenerator
{
    private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";  // in C# constant variables should be in PascalCase
    private const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
    private const string Digits = "0123456789";
    private const string SpecialChars = "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";
    private const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialChars;
    private static Random rnd = new Random();
    
    static void Main()
    {
        StringBuilder password = new StringBuilder();
   
        // Generate two random capital letters
        for (int i = 1; i <= 2; i++)
        {
            char capitalLetter = GenerateChar(CapitalLetters);
            InsertAtRandomPosition(password, capitalLetter);
        }

        // Generate two random small letters
        for (int i = 1; i <= 2; i++)
        {
            char smallLetter = GenerateChar(SmallLetters);
            InsertAtRandomPosition(password, smallLetter);
        }
        
        // Generate one random digit
        char digit = GenerateChar(Digits);
        InsertAtRandomPosition(password, digit);
        
        // Generate 3 special characters
        for (int i = 1; i <= 3; i++)
        {
            char specialChar = GenerateChar(SpecialChars);
            InsertAtRandomPosition(password, specialChar);
        }
        
        // Generate few random characters (between 0 and 7)
        int count = rnd.Next(8);
        for (int i = 1; i <= count; i++)
        {
            char specialChar = GenerateChar(AllChars);
            InsertAtRandomPosition(password, specialChar);
        }

        Console.WriteLine("Random Password: " + password);
    }

    private static void InsertAtRandomPosition(StringBuilder password, char character)
    {
        int randomPosition = rnd.Next(password.Length + 1);
        password.Insert(randomPosition, character);
    }

    private static char GenerateChar(string availableChars)
    {
        int randomIndex = rnd.Next(availableChars.Length);
        char randomChar = availableChars[randomIndex];
        
        return randomChar;
    }
}

/* Output:
Random Password: %]<0GzdtFS\2
*/