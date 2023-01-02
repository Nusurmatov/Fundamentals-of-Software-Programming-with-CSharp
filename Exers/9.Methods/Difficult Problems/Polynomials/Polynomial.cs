class Polynomial
{
    /*
    public static string polynomial1 = "(3x2 + x - 3)";       -> 3x2+x-3
    public static string polynomial2 = "(x - 1)";             -> x-1
    public static string polynomial3 = "(-7x2 + 5x - 17)";    -> -7x2+5x-17
    public static string polynomial4 = "(-x2 + 7)";           -> -x2+7       
    public static string polynomial5 = "(9x3)";               -> 9x3
    */
    public string Sum(params string[] monomials)
    {
        string result = String.Empty;
        Dictionary<string, int> polynomials = new Dictionary<string, int>();

        return  result;
    }

    public string Sum(string polynomialExperssion)
    {
        string result = String.Empty;
        result = Sum(ExtractMonomials(polynomialExperssion));

        return  result;
    }
    
    public string Sum(string polynomial1, string polynomial2)
    {
        string result = String.Empty;
        RemoveBracketsAndWhiteSpaces(ref polynomial1);
        RemoveBracketsAndWhiteSpaces(ref polynomial2);
        string concat = (polynomial2[0] == '-') ? (polynomial1 + polynomial2) : (polynomial1 + "+" + polynomial2);
        result = Sum(concat);
        
        return  result;
    }

    private static void RemoveBracketsAndWhiteSpaces(ref string polynomial)
    {
        while (true)
        {
            if (polynomial.Contains('('))
            {
                polynomial = polynomial.Remove(polynomial.IndexOf('('), 1);
            }
            else if (polynomial.Contains(')'))
            {
                polynomial = polynomial.Remove(polynomial.IndexOf(')'), 1);
            }
            else
            {
                break;
            }    
        }

        polynomial = polynomial.Replace(" ", String.Empty);

    }

    private static string[] ExtractMonomials(string polynomialExpression)
    {
        string[] result = new string[100];
        int startIndex = 0;
        int counter = 0;
        int j = 0;

        for (int i = 0; i < polynomialExpression.Length; i++)
        {
            if (polynomialExpression[i] == '+')
            {
                result[j] = (polynomialExpression.Substring(startIndex, counter));
                startIndex = i + 1;
                counter = -1;
                j++;
            }
            else if (polynomialExpression[i] == '-')
            {
                result[j] = (polynomialExpression.Substring(startIndex, counter));
                startIndex = i;
                counter = 0;
                j++;
            }
            counter++;
        }
        Console.WriteLine(result[0]);
        Console.WriteLine(result[1]);
        Console.WriteLine(result[2]);

        return result.ToArray();
    }
  
    public string Product(string[] monomials)
    {
        string result = String.Empty;

        return  result;
    }

    public string Product(string polynomialExperssion)
    {
        string result = String.Empty;

        return  result;
    }

    public string Product(string polynomial1, string polynomial2)
    {
        string result = String.Empty;

        return  result;
    }

    public string Pow(string polynomial, int power)  // for future extension of the class.
    {
        string result = String.Empty;

        return  result;

    }
}