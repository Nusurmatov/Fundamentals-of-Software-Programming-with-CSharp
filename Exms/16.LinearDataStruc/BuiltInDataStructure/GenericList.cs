namespace BuiltInDataStructure
{
    public static class GenericList
    {
        private static Random random = new Random();

        public static void DemoeGenericListContent()
        {
            Console.Write("\nThe program generates random List<int> for you, so enter the length : ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Now enter the minimum value of List<int> : ");
            int lowerBound = Convert.ToInt32(Console.ReadLine());
            Console.Write("Finally enter the maximum value of List<int> : ");
            int upperBound = Convert.ToInt32(Console.ReadLine());

            var firstList = GenerateRandomList(length, lowerBound, upperBound);
            var secondList = GenerateRandomList(length, lowerBound, upperBound);

            Console.Write($"Primes between {lowerBound} and {upperBound} : ");
            PrintList(GetPrimes(lowerBound, upperBound));

            Console.Write("First List : ");
            PrintList(firstList);    
            Console.Write("Second List : ");
            PrintList(secondList);    

            Console.Write("Union of two lists : ");
            PrintList(Union(firstList, secondList));
            Console.Write("Intersection of two lists : ");
            PrintList(Intersect(firstList, secondList));
        }

        public static List<int> GetPrimes(int start, int end)
        {
            var primesList = new List<int>();
            List<bool> isPrime = new List<bool>();
            isPrime.AddRange(Enumerable.Repeat<bool>(true, end + 1));
            
            // Sieve of Eratosthenes Algorithm for finding all primes in a given range
            for (int i = 2; i <= end; i++)
            {
                if (isPrime[i])
                {
                    if (i > 200) 
                    {
                        primesList.Add(i);
                    }

                    for (int j = i*i; j <= end; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            return primesList; 
        }

        public static List<int> Union(List<int> firstList, List<int> secondList)
        {
            List<int> union = new List<int>();
            union.AddRange(firstList);

            foreach (var item in secondList)
            {
                if (!union.Contains(item))
                {
                    union.Add(item);
                }
            }

            return union;
        }

        public static List<int> Intersect(List<int> firstList, List<int> secondList)
        {   
            List<int> intersect = new List<int>();
            
            foreach (var item in firstList)
            {
                if (secondList.Contains(item))
                {
                    intersect.Add(item);                    
                }
            }

            return intersect;
        }

        private static void PrintList<T>(List<T> items)
        {
            Console.Write("{ ");
            foreach (var item in items)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("}");
        }
    
        private static List<int> GenerateRandomList(int length, int lowerBound, int upperBound)
        {
            var result = new List<int>();

            for (int i = 0; i < length; i++)
            {
                result.Add(random.Next(lowerBound, upperBound));
            }

            return result;
        }
    }
}