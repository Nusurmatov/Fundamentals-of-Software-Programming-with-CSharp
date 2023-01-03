namespace CustomList
{
    public abstract class CustomList<T>
    {
        protected int count;

        public int Count => this.count;

        public abstract void Add(T item);

        public abstract void Insert(T item, int index);

        public abstract int Remove(T item);

        public abstract T RemoveAt(int index);

        public abstract bool Contains(T item);

        public abstract int IndexOf(T item);

        public abstract void Clear();
        
        protected void CheckArgumentOutOfRangeException(int index)
        {
            if (index > this.count || index < 0) 
            { 
                throw new ArgumentOutOfRangeException($"Invalid index: {index}.");
            }
        }
    }
}