public class CustomArrayList<T>
{
    private const int InitialCapacity = 4;

    private T[] arr;
    private int count;

    public int Count => this.count;

    public CustomArrayList(int capacity = InitialCapacity)
    {
        this.arr = new T[capacity];
        this.count = 0;
    }

    public void Add(T item)
    {
        GrowIfArraySizeIsFull();
        this.arr[this.count] = item;
        this.count++;
    }

    public void Insert(T item, int index)
    {
        CheckThrowArgumentOutOfRangeException(index);

        GrowIfArraySizeIsFull();
        Array.Copy(this.arr, index, this.arr, index + 1, this.count - index);
        this.arr[index] = item;
        this.count++;
    }

    public int Remove(T item)
    {
        int index = IndexOf(item);
        if (index != -1)
        {
            RemoveAt(index);
        }

        return index;
    }

    public T RemoveAt(int index)
    {
        CheckThrowArgumentOutOfRangeException(index);

        T item = this.arr[index];
        Array.Copy(this.arr, index + 1, this.arr, index, this.count - index - 1);
        this.arr[this.count - 1] = default(T); 
        this.count--;

        return item;
    }

    public bool Contains(T item)
    {
        int index = IndexOf(item);
        bool found = (index != -1);
        
        return found;
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < this.arr.Length; i++)
        {
            if (Object.Equals(this.arr[i], item))
            {
                return i;
            }
        }       

        return -1;
    }

    public void Clear()
    {
        this.arr = new T[InitialCapacity];
        this.count = 0;
    }

    public T this[int index]
    {
        get 
        {
            CheckThrowArgumentOutOfRangeException(index);

            return this.arr[index];
        }
        set
        {
            CheckThrowArgumentOutOfRangeException(index);

            this.arr[index] = value;
        }
    }

    private void GrowIfArraySizeIsFull()
    {
        if (this.count + 1 > this.arr.Length)
        {
            var extendedArray = new T[this.arr.Length * 2];
            Array.Copy(this.arr, extendedArray, this.count);
            this.arr = extendedArray;
        }
    }

    private void CheckThrowArgumentOutOfRangeException(int index)
    {
        if (index > this.count || index < 0) 
        { 
            throw new ArgumentOutOfRangeException($"Invalid index: {index}.");
        }
    }
}