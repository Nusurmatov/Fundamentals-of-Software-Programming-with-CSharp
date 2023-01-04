namespace BuiltInDataStructure
{
    public static class GenericList
    {
        // Sieve of Eratosthenes
        public static List<int> GetPrimes(int start, int end)
        {
            var primesList = new List<int>();
            for (int i = 0; i < end; i++)
            {

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
    }
}