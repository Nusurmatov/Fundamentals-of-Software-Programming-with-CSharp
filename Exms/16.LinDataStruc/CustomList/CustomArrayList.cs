namespace CustomList
{
    public class CustomArrayList<T> : CustomList<T>
    {
        private const int InitialCapacity = 4;

        private T[] arr;

        public CustomArrayList(int capacity = InitialCapacity)
        {
            this.arr = new T[capacity];
            base.count = 0;
        }

        public override void Add(T item)
        {
            GrowIfArraySizeIsFull();
            this.arr[base.count] = item;
            base.count++;
        }

        public override void Insert(T item, int index)
        {
            if (index > this.count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index: " + index);
            }

            GrowIfArraySizeIsFull();
            Array.Copy(this.arr, index, this.arr, index + 1, base.count - index);
            this.arr[index] = item;
            base.count++;
        }

        public override int Remove(T item)
        {
            int index = IndexOf(item);
            if (index != -1)
            {
                RemoveAt(index);
            }

            return index;
        }

        public override T RemoveAt(int index)
        {
            base.CheckArgumentOutOfRangeException(index);

            T item = this.arr[index];
            Array.Copy(this.arr, index + 1, this.arr, index, base.count - index - 1);
            this.arr[base.count - 1] = default(T);
            base.count--;

            return item;
        }

        public override bool Contains(T item)
        {
            int index = IndexOf(item);
            bool found = (index != -1);

            return found;
        }

        public override int IndexOf(T item)
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

        public override void Clear()
        {
            this.arr = new T[InitialCapacity];
            base.count = 0;
        }

        public override T this[int index]
        {
            get
            {
                base.CheckArgumentOutOfRangeException(index);

                return this.arr[index];
            }
            set
            {
                base.CheckArgumentOutOfRangeException(index);

                this.arr[index] = value;
            }
        }

        private void GrowIfArraySizeIsFull()
        {
            if (base.count + 1 > this.arr.Length)
            {
                var extendedArray = new T[this.arr.Length * 2];
                Array.Copy(this.arr, extendedArray, base.count);
                this.arr = extendedArray;
            }
        }
    }
}