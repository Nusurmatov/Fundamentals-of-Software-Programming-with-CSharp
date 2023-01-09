using System.Collections;

public class Deque<T>
{
    private Node? front;
    private Node? rear;

    public int Count { get; private set; }

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

    public Deque()
    {
        this.front = null;
        this.rear = null;
        this.Count = 0;
    }

    public void Enqueue(T item)
    {
        if (this.Count == 0)
        {
            Node newNode = new Node(item);
            this.front = newNode;
            this.rear = newNode;
        }
        else
        {
            Node? newNode = this.rear;
            newNode.prev = new Node(item, next: this.rear);
            this.rear = newNode.prev;
        }

        this.Count++;
    }

    public T Dequeue()
    {
        if (this.rear != null)
        {
            T returnValue = this.rear.value;
            this.rear = this.rear.next;
            this.rear.prev = null;
            this.Count--;

            return returnValue;
        }
        else
        {
            throw new ArgumentException("The deque is Empty!");
        }
    }

    public void Push(T item)
    {
        if (this.Count == 0)
        {
            Node newNode = new Node(item);
            this.rear = newNode;
            this.front = newNode;
        }
        else
        {
            Node? newNode = this.front;
            newNode.next = new Node(item, prev: this.front);
            this.front = newNode.next;
        }
            
        this.Count++;            
    }

    public T Pop()
    {
        if (this.front != null)
        {
            T returnValue = this.front.value;
            this.front = this.front.prev;
            this.front.next = null;
            this.Count--;

            return returnValue;
        }
        else
        {
            throw new ArgumentException("The deque is Empty!");
        }
    }

    public T Peek(bool atFront = true)
    {
        if (atFront)
        {
            return (this.front != null) ? this.front.value : throw new ArgumentException("The deque is Empty!");
        }
        else
        {
            return (this.rear != null) ? this.rear.value : throw new ArgumentException("The deque is Empty!");
        }
    }

    public bool Contains(T item)
    {
        Node? currentNode = this.rear;
        while (currentNode != null)
        {
            if (currentNode.value.Equals(item))
            {
                return true;
            }

            currentNode = currentNode.next;
        }

        return false;
    }

    public void Clear()
    {
        this.front = null;
        this.rear = null;
        this.Count = 0;
    }

    public override string ToString()
    {
        if (this.Count == 0)  return "Empty!";

        Node? currentNode = this.front;
        var result = new System.Text.StringBuilder("{ ");
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

            currentNode = currentNode.prev;
            currentIndex++;
        }

        return result.Append("}").ToString();
    }
}
