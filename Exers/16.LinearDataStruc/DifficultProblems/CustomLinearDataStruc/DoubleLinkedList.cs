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

    public int Size { get; private set; }

    public DoubleLinkedList()
    {
        this.head = null;
        this.tail = null;
        this.Size = 0;
    }

    public bool IsEmpty() => this.Size == 0;

    public void Add(T value, bool IsAddLast = true)
    {
        if (this.IsEmpty())
        {
            Node newNode = new Node(value, null, null);
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

        this.Size++;
    }

    public void Insert(T valueToInsert, int index)
    {
        if (index > this.Size || index < 0)
        {
            throw new ArgumentOutOfRangeException($"Invalid index: {index}!");
        }
        else if (index == 0)
        {
            this.Add(valueToInsert, IsAddLast: false);
        }
        else if (index == this.Size)
        {
            this.Add(valueToInsert);
        }
        else
        {
            Node? currentNode = this.head.next;
            int currentIndex = 1;

            while (currentNode != null)
            {
                if (currentIndex == index)
                {
                    Node newNode = new Node(valueToInsert, currentNode, currentNode.prev);
                    currentNode.prev.next = newNode;
                }                

                currentNode = currentNode.next;
                currentIndex++;
            } 

            this.Size++;
        }
    }

    public void Insert(T valueToInsert, T key, bool IsInsertAfter = true)  // key is the item which the value is to be inserted after or before
    {
        

        throw new KeyNotFoundException($"There is no such item: {key}!");
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
                if (currentNode == this.head)
                {
                    this.head = currentNode.next;
                    currentNode.next = null;
                }
                else if (currentNode == this.tail)
                {
                    this.tail = currentNode.prev;
                    currentNode = null;
                }
                else
                {
                    currentNode.prev.next = currentNode.next;
                    currentNode = null;
                }
            } 

            currentNode = currentNode.next;   
        }


        return -1;
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
        this.Size = 0;
    }

    public override string ToString()
    {
        if (IsEmpty())  return "Empty!";

        var result = new System.Text.StringBuilder("{ ");
        Node? currentNode = this.head;
        int currentIndex = 0;

        while (currentNode != null)
        {
            if (currentIndex < this.Size - 1)
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

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}