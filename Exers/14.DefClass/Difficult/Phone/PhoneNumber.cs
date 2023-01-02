public struct PhoneNumber
{
    private const string defaultContryCode = "+998";
    public static HashSet<int> validUzbekAreaCodes; 
    public string CountryCode { get; set; }
    public int AreaCode { get; private set; }
    public string Number { get; set; }

    static PhoneNumber()
    {
        validUzbekAreaCodes = new HashSet<int>()
        {
            33, 88, 90, 91, 93, 94, 95, 97, 98, 99
        };
    }

    public PhoneNumber() 
    {
        this.CountryCode = defaultContryCode;
        this.AreaCode = 99;
        this.Number = SetPhoneNumber(this.CountryCode, 0);
    }
    public PhoneNumber(string countryCode) : this(countryCode, 99, 0) { }
    public PhoneNumber(int phoneNumber) : this(defaultContryCode, 99, phoneNumber) { }
    public PhoneNumber(string countryCode, int areaCode, int phoneNumber)
    {
        this.CountryCode = countryCode;
        this.AreaCode = areaCode;
        this.Number = SetPhoneNumber(countryCode, areaCode, phoneNumber);
    }

    private static string SetPhoneNumber(string countryCode, int areaCode = 99, int phoneNumber = 0)
    {
        var result = new System.Text.StringBuilder();

        if (phoneNumber == 0)
        {
            result.Append($"{countryCode}** *** ** **");
        }
        else
        {
            result.Append($"{countryCode}{areaCode} ");
            result.Append($"{(phoneNumber / 10000)} ");
            result.Append($"{(phoneNumber % 10000 / 100)} ");
            result.Append($"{(phoneNumber % 100):D2}");
        }

        return result.ToString();
    }

/* For future rafactoring:  
    private static bool ValidatePhoneNumber(string number)
    {

    }

    private static bool ValidateCountryCode(string countryCode)
    {

    }

    private static bool ValidateAreaCode() {}
*/

    public override string ToString()
    {
        return this.Number;
    }
}