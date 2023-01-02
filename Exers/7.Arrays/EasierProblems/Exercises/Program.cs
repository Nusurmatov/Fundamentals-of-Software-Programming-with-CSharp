/* (Easier Problems) Ex3 - Problem Statement:
Write a program, which finds the maximal sequence of consecutive
equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1} -> {2, 2, 2}.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        char[] array1 = { 'a', 's', 's', 'o', 'c', 'i', 'a', 't', 'i', 'o', 'n' };
        char[] array2 = { 'a', 'p', 'p', 'r', 'e', 'c', 'i', 'a', 't', 'i', 'o', 'n' };
        char[] array3 = { 'a', 'd', 'm', 'i', 'n', 'i', 's', 't', 'r', 'a', 't', 'i', 'o', 'n' };
        char[] array4 = { 'a', 'd', 'm', 'i', 'n', 'i', 's', 't', 'r', 'a', 't', 'i', 'v', 'e' };
        char[] array5 = { 'a', 's', 's', 'o', 'c', 'i', 'a', 't', 'e' };

        string result1 = Program.LexicographicalCompareOfCharArrays(array1, array2);
        Console.WriteLine("Bigger one is {0}", result1);
        string result2 = Program.LexicographicalCompareOfCharArrays(array1, array2, array3);
        Console.WriteLine("Bigger one is {0}", result2);
        string result3 = Program.LexicographicalCompareOfCharArrays(array1, array2, array3, array4);
        Console.WriteLine("Bigger one is {0}", result3);
        string result4 = Program.LexicographicalCompareOfCharArrays(array1, array2, array3, array4, array5);
        Console.WriteLine("Bigger one is {0}", result4);
    }

        public static string LexicographicalCompareOfCharArrays(char[] arr1, char[] arr2)
        {
            Console.WriteLine($"Comparing {arr1} and {arr2} lexicographically: ");

            return new string("");
        }

        public static string LexicographicalCompareOfCharArrays(char[] arr1, char[] arr2, char[] arr3)
        {

            return new string("");
        }

        public static string LexicographicalCompareOfCharArrays(char[] arr1, char[] arr2, char[] arr3, char[] arr4)
        {

            return new string("");
        }

        public static string LexicographicalCompareOfCharArrays(char[] arr1, char[] arr2, char[] arr3, char[] arr4, char[] arr5)
        {
            return new string("");
        }
}

/* Input/Output
How many elements do you want for first array to have? : 3
How about your second array ? : 7
No need for entering array elements, they are never goint to be equal
As you entered different lenghts...
How many elements do you want for first array to have? : 3
How about your second array ? : 3
Start entering elements for the first array!
Remember they all must be of type int otherwise you will receive nice little error...
Enter element1: 7
Enter element2: 8
Enter element3: 8
Start entering elements for the second array!
Remember they all must be of type int otherwise you will receive nice little error...
Enter element1: 7
Enter element2: 8
Enter element3: 8
Are they equal? : True.
*/