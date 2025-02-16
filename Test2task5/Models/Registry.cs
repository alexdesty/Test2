namespace Test2task5.Models
{
    internal class Registry<T> : IAddable<T>, IRemovable<T>
    {
        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public List<T> GetAllItems()
        {
            List<T> copy = new List<T>();
            foreach (T item in items)
            {
                copy.Add(item);
            }
            return copy;
        }
        public void RemoveItem(T item)
        {
            items.Remove(item);
        }
    }
}
