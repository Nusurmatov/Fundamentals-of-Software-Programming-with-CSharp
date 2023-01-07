namespace CustomList
{
    public class DynamicList<T> : CustomList<T>
    {
        private class ListNode
        {
            public T Element { get; set; }

            public ListNode? NextNode { get; set; }

            public ListNode(T element)
            {
                this.Element = element;
                this.NextNode = null;
            }

            public ListNode(T element, ListNode prevNode)
            {
                this.Element = element;
                prevNode.NextNode = this;
            }
        }

        private ListNode? head;
        private ListNode? tail;

        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            base.count = 0;
        }

        public override void Add(T item)
        {
            if (this.head == null)
            {
                this.head = new ListNode(item);
                this.tail = this.head;
            }
            else
            {
                ListNode newNode = new ListNode(item, this.tail);
                this.tail = newNode;
            }

            base.count++;
        }

        public override void Insert(T item, int index)
        {
            CheckArgumentOutOfRangeException(index);

            ListNode? newNode = new ListNode(item);
            
            if (this.head == null)
            {
                this.head = newNode;
                this.tail = this.head;
            }
            else
            {
                ListNode? currentNode = this.head;
                ListNode? prevNode = null;
                
                for (int i = 0; i < index; i++)
                {
                    prevNode = currentNode;
                    currentNode = currentNode.NextNode;
                }

                newNode.NextNode = currentNode;

                if (index == 0)
                {
                    this.head = newNode;
                }
                else if (index == base.count - 1)
                {
                    this.tail = newNode;
                }
                else 
                {
                    prevNode.NextNode = newNode;
                }
            }

            base.count++;
        }

        public override int Remove(T item)
        {
            int currentIndex = 0;
            ListNode? currentNode = this.head;
            ListNode? prevNode = null;
            while (currentNode != null)
            {
                if (Object.Equals(currentNode.Element, item))
                {
                    break;
                }

                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            if (currentNode != null)
            {
                RemoveListNode(currentNode, prevNode);
            
                return currentIndex;
            }

            return -1;
        }

        public override T RemoveAt(int index)
        {
            CheckArgumentOutOfRangeException(index);

            int currentIndex = 0;
            ListNode? currentNode = this.head;
            ListNode? prevNode = null;
            while (currentIndex < index)
            {
                prevNode = currentNode;
                currentNode = currentNode?.NextNode; 
                currentIndex++;
            }

            RemoveListNode(currentNode, prevNode);

            return currentNode.Element;
        }

        public override bool Contains(T item)
        {
            int index = IndexOf(item);

            return (index != -1);
        }

        public override int IndexOf(T item)
        {
            int currentIndex = 0;
            ListNode? currentNode = this.head;
            while (currentNode != null)
            {
                if (Object.Equals(currentNode.Element, item))
                {
                    return currentIndex;
                }            

                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            return -1;
        }

        public override void Clear()
        {
            this.head = null;
            this.tail = null;
            base.count = 0;
        }

        public override T this[int index]
        {
            get
            {
                CheckArgumentOutOfRangeException(index);

                ListNode? currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }

                return currentNode.Element;
            }
            set
            {
                CheckArgumentOutOfRangeException(index);

                ListNode? currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }

                currentNode.Element = value;
            }
        }
        
        private void RemoveListNode(ListNode node, ListNode prevNode)
        {
            base.count--;
            if (base.count == 0)
            {
                // The list becomes empty -> remove head and tail
                this.head = null;
                this.tail = null;
            }
            else if (prevNode == null)
            {
                // The head node removed -> update the head
                this.head = node.NextNode;
            }
            else
            {
                // Redirect the pointer to skip the removed node
                prevNode.NextNode = node.NextNode;
            }

            // Fix the tail if it was removed
            if (Object.Equals(this.tail, node))
            {
                this.tail = prevNode;
            }
        }
    }
}