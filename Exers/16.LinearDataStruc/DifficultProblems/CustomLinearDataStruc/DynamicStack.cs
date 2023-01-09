using System.Collections;

public class DynamicStack<T> : IEnumerable<T>, IReadOnlyCollection<T>
{
    private Node? lastAdded;
    private int count;

    public int Count => this.count;

    private class Node
    {
        public T value;
        public Node? prev;

        public Node(T item, Node? prev = null)
        {
            this.value = item;
            this.prev = prev;
        }
    }

    public DynamicStack()
    {
        this.lastAdded = null;
        this.count = 0;
    }

    public void Push(T item)
    {
        Node? newNode = new Node(item, lastAdded);
        lastAdded = newNode;
        this.count++;
    }

    public T? Peek() => (this.lastAdded != null) ? this.lastAdded.value : default(T);

    public T? Pop()
    {
        if (this.lastAdded != null)
        {
            T returnValue = lastAdded.value;
            lastAdded = lastAdded.prev;
            this.count--;
            
            return returnValue;
        }
        else
        {
            return default(T);
        }
    }

    public bool TryPeek(out T? result) 
    {
        if (this.lastAdded != null)
        {
            result = lastAdded.value;
            
            return true;
        }
        else
        {
            result = default(T);
            
            return false;
        }
    }

    public bool TryPop(out T? result)
    {
        if (this.lastAdded != null)
        {
            result = lastAdded.value;
            lastAdded = lastAdded.prev;
            this.count--;

            return true;
        }
        else
        {
            result = default(T);

            return false;   
        }
    }

    public bool Contains(T item)
    {
        Node? currentNode = lastAdded;
        while (currentNode != null)
        {
            if (currentNode.value.Equals(item))
            {
                return true;
            }

            currentNode = currentNode.prev;
        }

        return false;
    }

    public void Clear()
    {
        this.lastAdded = null;
        this.count = 0;
    }

    public override string ToString()
    {
        if (this.count == 0)  return "Empty!";

        Node? currentNode = lastAdded;
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

        return result.AppendLine("}").ToString();
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node? currendNode = lastAdded;
        while (currendNode != null)
        {
            yield return currendNode.value;
            currendNode = currendNode.prev;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}