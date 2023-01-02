class Combinations
{
    public void AllCombinationsInInterval(int[] array, int n, int k)
    {
        for (int i = 0; i < k; i++)
        {
            array[i] = 1;
        }

        int[] copy = array;

       // int counter = 0;
        for (int i = 1; true;)
        {
            Console.Write("{ ");
            for (int j = 0; j < k; j++)
            {
                if (j == k - 1)
                {
                    Console.Write($"{copy[j]}" + " }, ");
                }
                else
                {
                    Console.Write($"{copy[j]}, ");
                }
            }

            if (array[0] == n && array[1] == n)
            {
                break;
            }

            if (k - i < 0)
            {
                i = 1;
                copy = array;
            }

            (copy[k-i])++; 

        }
    }

    public void AllCombinationsInRange(int[] array, int n, int k)
    {

    }

    private static void NicePrinting(ref int counter)
    {

    }

}