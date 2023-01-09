public static class ExtensionMethods
{
    public static T[] ToArray<T>(this IEnumerable<T> enumerable)
    {
        T[] array = new T[enumerable.Count()];
        int index = 0;

        foreach (var item in enumerable)
        {
            array[index] = item;
            index++;
        }
        
        return array;
    }

    public static void SortCustom(this List<int> list, bool IsAscending = true)
    {
        int tmp;

        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = i; j < list.Count- 1; j++)
            {
                if (IsAscending)
                {
                    if (list[j] > list[j+1])
                    {
                        (list[j], list[j+1]) = (list[j+1], list[j]);
                    }
                }
                else
                {
                    if (list[j] < list[j+1])
                    {
                        (list[j], list[j+1]) = (list[j+1], list[j]);
                    }
                }
            }
        }
    }
}