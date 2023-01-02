namespace NumberConverter
{
    public static class ConvertNumber
    {
        enum Numbers { A = 10, B, C, D, E, F };

        public static string FromPositiveIntegerToBinary(string num)
        {
            return FromBase10ToBinary(num);
        }

        public static string FromBinaryToPositiveInteger(string binNum)
        {
            return FromBinaryToBase10(binNum);
        }

        public static string FromPositiveIntegerToHexadecimal(string num)
        {
            return FromBase10ToBinary(num, 16);
        }

        public static string FromHexadecimalToPositiveInteger(string hexNum)
        {
            return FromBinaryToBase10(hexNum.ToUpper(), 16);
        }

        public static string FromBaseNToBaseM(string num, int fromBase = 2, int toBase = 10)
        {
            string result = String.Empty;
            result = FromBinaryToBase10(num.ToUpperInvariant(), fromBase);
            result = FromBase10ToBinary(result, toBase);

            return result;
        }

        private static string FromBase10ToBinary(string num, int toBase = 2)
        {
            string result = String.Empty;
            int n; 
            if (int.TryParse(num, out n)) 
            { 
                if (n < 0)
                {
                    result = "This program is intended to work on only positive integers FOR NOW...!";
                }
            }
            else
            {
                result = $"The entered number is not an integer but {num.GetType()}...!";
            }

            if (toBase == 10)
            {
                return num;
            }
            else if ((toBase > 1 && toBase < 10) || (toBase > 10 && toBase < 17))
            {
                while (n > 0)
                {
                    switch (n % toBase)    // with dictionary it would even become easier...
                    {
                        case 10:
                            result = Numbers.A + result;
                            break;
                        case 11:
                            result = Numbers.B + result;
                            break;
                        case 12:
                            result = Numbers.C + result;
                            break;
                        case 13:
                            result = Numbers.D + result;
                            break;
                        case 14:
                            result = Numbers.E + result;
                            break;
                        case 15:
                            result = Numbers.F + result;
                            break;
                        default:
                            result = (n % toBase) + result;
                            break;
                    }
                    
                    n /= toBase;
                }
            }
            else 
            {
                result = $"A number cannot have a base {toBase}...!";
            }
            
            if (toBase == 16)
            {
                result = "0x" + result;
            }

            return result;
        }

        private static string FromBinaryToBase10(string num, int fromBase = 2)
        {
            int result = 0;
            if (num.ToLowerInvariant().Contains("0X"))
            {
                num = num.Remove(0, 2);   // removing '0x'
            }

            if (fromBase == 10)
            {
                result = int.Parse(num);
            }
            else if ((fromBase > 1 && fromBase < 10) || (fromBase > 10 && fromBase < 17))
            {
                var NumbersDictionary = new Dictionary<char, int> { ['A'] = 10, ['B'] = 11, ['C'] = 12, ['D'] = 13, ['E'] = 14, ['F'] = 16 };
                // ['A'] = 11 .NET 6 feature (that should be checked...)

                for (int i = num.Length - 1, j = 1; i >= 0; i--, j *= fromBase)
                {
                    switch(num[i])
                    {
                        case 'A':
                        case 'B':
                        case 'C':
                        case 'D':
                        case 'E':
                        case 'F':
                            result += NumbersDictionary[num[i]] * j;
                            break;
                        default:
                            result += (int.Parse(num[i].ToString())) * j;
                            break;
                    }
                }
            }
            else
            {
                return "Invalid Parameter Input";
            }

            return result.ToString();
        }

        public static string HornerScheme(string num)
        {
            string result = String.Empty;
            int n;

            if (string.IsNullOrWhiteSpace(num))
            {
                result =  "You entered noting...!";
            }
            else
            {
                if (num[0] == 48 || num[0] == 49)
                {
                    n = num[0] - 48;
                }
                else
                {
                    result = $"A binary number cannot contain a digit {num[0]}";
                }
            }

            if (int.TryParse(num, out n))
            {
                if (num[0] == 48 || num[0] == 49)
                {
                    n = num[0] - 48;
                }
                else
                {
                    result = $"A binary number cannot contain a digit {num[0]}...!";
                }
            
                for (int i = 1; i < num.Length; i++)
                {
                    if (num[i] == 48 || num[i] == 49)
                    {
                        n = n * 2 + (num[i] - 48);      
                    }
                    else
                    {
                        return $"A binary number cannot contain a digit {num[i]}...!";
                    }
                }

                result = n.ToString();
            }
            else
            {
                result = $"Do you think '{num}' is binary? Come On...";
            }

            return result.ToString();
        }

        public static string FromRomanToArabic(string num)
        {
            num = num.ToUpperInvariant();
            var romanNumbers = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},    
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            string result = String.Empty;
            int arabicNumber = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (romanNumbers.ContainsKey(num[i]))
                {
                    if ((i < num.Length - 1) && (romanNumbers[num[i]] >= romanNumbers[num[i+1]]))
                    {
                        arabicNumber += romanNumbers[num[i]];
                    }
                    else
                    {
                        arabicNumber = (i != num.Length - 1) ? arabicNumber - romanNumbers[num[i]] : arabicNumber + romanNumbers[num[i]];
                    }
                }
                else
                {
                    return $"Roman numbers cannot contain {num[i]}";
                }
            }

            result = arabicNumber.ToString();
            return result;
        }

        public static string FromArabicToRoman(string num)
        {
            string result = String.Empty;
            int n;

            if (int.TryParse(num, out n))
            {
                if (n < 1)
                {
                    result = "Roman numbers cannot be less than 1...!";
                }
                else
                {
                    int m = n / 1000;  // m - 1000, m deals with digit(s) which has a value greater than 1000
                    for (int i = 0; i < m; i++)
                    {
                        result += "M";
                    }

                    int cd =(n % 1000) / 100 ;  // cd deals with digit which has a value greater than 100 less than 1000. 
                    // c - 100, d - 500.
                    FillRomanDigits(ref result, cd, "C", "D", "M");

                    int xl = (n % 100) / 10 ;  // xl deals with digit which has a value greater than 10 less than 100. 
                    // x - 10, l - 50.
                    FillRomanDigits(ref result, xl, "X", "L", "C");

                    int iv = n % 10 ;  // iv deals with digit which has a value less than 10. 
                    FillRomanDigits(ref result, iv, "I", "V", "X");
                }
            }
            else
            {
                result = "Invalid input...!";
            }

            return result;
        }

        private static void FillRomanDigits(ref string result, int arabDigit, string romanSmallerDigit, string romanBiggerDigit, string romanBigDigit)
        {
            switch (arabDigit)
            {
                case 1:
                    result += romanSmallerDigit;  
                    break;
                case 2:
                    result += romanSmallerDigit + romanSmallerDigit;  
                    break;
                case 3:
                    result += romanSmallerDigit + romanSmallerDigit + romanSmallerDigit;  
                    break;
                case 4:
                    result += romanSmallerDigit + romanBiggerDigit;  
                    break;
                case 5:
                    result += romanBiggerDigit;  
                    break;
                case 6:
                    result += romanBiggerDigit + romanSmallerDigit; 
                    break;
                case 7:
                    result += romanBiggerDigit + romanSmallerDigit + romanSmallerDigit;  
                    break;
                case 8:
                    result += romanBiggerDigit + romanSmallerDigit + romanSmallerDigit + romanSmallerDigit;  
                    break;
                case 9:
                    result += romanSmallerDigit + romanBigDigit;  
                    break;
            }            
        }
    }
}