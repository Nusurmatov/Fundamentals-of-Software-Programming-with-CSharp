using System.Collections;

public class CircularQueue<T> : IEnumerable<T>
{
    private const int InitialCapacity = 5;

    private T[] arr;
    private int front;
    private int rear;

    public int Count { get; private set; }

    public CircularQueue(int capacity = InitialCapacity)
    {
        this.arr = new T[capacity];
        this.front = -1;
        this.rear = -1;
        this.Count = 0;
    }

    public void Enqueue(T item)
    {
        GrowIfArrayIsFull();

        if (this.front == -1)
        {
            this.front = 0;
        }

        this.rear = (this.rear + 1) % this.arr.Length;
        this.arr[this.rear] = item;
        this.Count++;
    }

    public T Dequeue()
    {
        T item = this.Peek();

        if (this.front == this.rear)
        {
            this.front = -1;
            this.rear = -1;
        }
        else
        {
            this.front = (this.front + 1) % this.arr.Length;
        }
        this.Count--;
        
        return item;
    }

    public T Peek()
    {
        if (this.Count == 0)
        {
            throw new ArgumentException("Circular Queue is Empty!");
        }
        
        return this.arr[this.front];
    }

    public bool Contains(T item)
    {
        for (int i = this.front; i <= this.rear; i++)
        {
            if (object.Equals(this.arr[i], item))
            {
                return true;
            }
        }

        return false;
    }

    public void Clear()
    {
        this.arr = new T[InitialCapacity];
        this.front = -1;
        this.rear = -1;
        this.Count = 0;
    }

    private void GrowIfArrayIsFull()
    {
        if (this.Count == this.arr.Length)
        {
            T[] extendedArr = new T[this.Count * 2];
            Array.Copy(this.arr, extendedArr, this.arr.Length);
            this.arr = extendedArr;
        }
    }

    public override string ToString()
    {
        if (this.Count == 0)  return "Circular Queue is Empty!";
        var result = new System.Text.StringBuilder("{ ");

        for (int i = this.front; i <= this.rear; i++)
        {
            result.Append((i != this.rear) ? $"{this.arr[i]}, " : $"{this.arr[i]}");
        }

        return result.Append(" }").ToString();
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.front; i <= this.rear; i++)
        {
            yield return this.arr[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}