using System.Collections;

public class DoubleLinkedList<T> : IEnumerable<T>
{
    private class Node
    {
        public T value;
        public Node? next;
        public Node? prev;

        public Node(T item, Node? next = null, Node? prev = null)
        {
            this.value = item;
            this.next = next;
            this.prev = prev;
        }
    }

    private Node? head;
    private Node? tail;

    public int Count { get; private set; }

    public T? First => (this.head != null) ? this.head.value : default(T);

    public T? Last => (this.tail != null) ? this.tail.value : default(T);

    public DoubleLinkedList()
    {
        this.head = null;
        this.tail = null;
        this.Count = 0;
    }

    public bool IsEmpty() => this.Count == 0;

    public void Add(T value, bool IsAddLast = true)
    {
        if (this.IsEmpty())
        {
            Node newNode = new Node(value);
            this.head = newNode;
            this.tail = newNode;
        }
        else
        {
            if (IsAddLast)
            {
                Node? newNode = this.tail;
                newNode.next = new Node(value, prev: this.tail);
                this.tail = newNode.next;
            }
            else
            {
                Node? newNode = this.head;
                newNode.prev = new Node(value, next: this.head);
                this.head = newNode.prev;    
            }
        }

        this.Count++;
    }

    public void Insert(T valueToInsert, T key, bool IsInsertAfter = true)  // key is the item which the value is to be inserted after or before
    {
        

        throw new KeyNotFoundException($"There is no such item: {key}!");
    }

    public void InsertAt(T valueToInsert, int index)
    {
        if (index > this.Count || index < 0)
        {
            throw new ArgumentOutOfRangeException($"Invalid index: {index}!");
        }
        else if (index == 0)
        {
            this.Add(valueToInsert, IsAddLast: false);
        }
        else if (index == this.Count)
        {
            this.Add(valueToInsert);
        }
        else
        {
            Node? currentNode = this.head;
            int currentIndex = 0;

            while (currentNode != null)
            {
                if (currentIndex == index)
                {
                    Node newNode = new Node(valueToInsert, currentNode, currentNode.prev);
                    currentNode.prev.next = newNode;
                    currentNode.prev = newNode;
                }                

                currentNode = currentNode.next;
                currentIndex++;
            } 

            this.Count++;
        }
    }

    public int Remove(T value)
    {
        if (IsEmpty())
        {
            return -1;
        }

        Node? currentNode = this.head;
        while (currentNode != null)
        {
            if (currentNode.value.Equals(value))
            {
                if (currentNode.prev != null)
                {
                    currentNode.prev.next = currentNode.next;
                }
                else
                {
                    this.head = currentNode.next;
                }

                if (currentNode.next != null)
                {
                    currentNode.next.prev = currentNode.prev;
                }
                else
                {
                    this.tail = currentNode.prev;
                }

                this.Count--;
                break;
            } 

            currentNode = currentNode.next;   
        }

        return -1;
    }
    
    public void RemoveAt(int index)
    {
        if (index >= this.Count || index < 0)
        {
            throw new ArgumentOutOfRangeException($"Invalid index: {index}!");
        }

        Node? currentNode = this.head;
        int currentIndex = 0;
        
        while (currentNode != null)
        {
            if (currentIndex == index)
            {
                this.Remove(currentNode.value);
                break;
            }

            currentNode = currentNode.next;
            currentIndex++;
        }
    }

    public T GetAt(int index)
    {
        if (index >= this.Count || index < 0)
        {
            throw new ArgumentOutOfRangeException($"Invalid index: {index}!");
        }

        Node? currentNode;
        int currentIndex;
        bool startFromHead = true;
        if (index < this.Count/2)
        {
            currentNode = this.head;
            currentIndex = 0;
        }
        else
        {
            currentNode = this.tail;
            currentIndex = this.Count - 1;
            startFromHead = false;
        }

        while (currentNode != null)
        {
            if (currentIndex == index)
            {
                break;
            }

            currentNode = (startFromHead) ? currentNode.next : currentNode.prev;
            currentIndex += (startFromHead) ? 1 : -1;
        }

        return currentNode.value;
    }

    public bool Contains(T value)
    {
        Node? currentNode = this.head;

        while (currentNode != null)
        {
            if (currentNode.value.Equals(value))
            {
                return true;
            }

            currentNode = currentNode.next;
        }

        return false;
    }

    public int IndexOf(T value)
    {
        Node? currentNode = this.head;
        int currentIndex = this.IsEmpty() ? -1 : 0;
        bool contains = false;

        while (currentNode != null)
        {
            if (currentNode.value.Equals(value))
            {
                contains = true;
                break;
            }

            currentNode = currentNode.next;
            currentIndex++;
        }

        return (contains) ? currentIndex : -1;
    }

    public void Clear()
    {
        this.head = null;
        this.tail = null;
        this.Count = 0;
    }

    public T this[int index] => this.GetAt(index);

    public override string ToString()
    {
        if (IsEmpty())  return "Empty!";

        var result = new System.Text.StringBuilder("{ ");
        Node? currentNode = this.head;
        int currentIndex = 0;

        while (currentNode != null)
        {
            if (currentIndex < this.Count - 1)
            {
                result.Append($"{currentNode.value}, ");
            }
            else
            {
                result.Append($"{currentNode.value} ");
            }

            currentNode = currentNode.next;
            currentIndex++;
        }

        return result.AppendLine("}").ToString();
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node? currentNode = this.head;
        while (currentNode != null)
        {
            yield return currentNode.value;
            currentNode = currentNode.next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}