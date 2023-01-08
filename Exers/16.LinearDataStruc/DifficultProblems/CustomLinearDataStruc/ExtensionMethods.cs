public static class ExtensionMethods
{
    public static T[] ToArray<T>(this DoubleLinkedList<T> doubleLinkedList)
    {
        T[] array = new T[doubleLinkedList.Size];
        int index = 0;

        foreach (var item in doubleLinkedList)
        {
            array[index] = item;
            index++;
        }

        return array;
    }
}