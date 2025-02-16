namespace Test2task5.Models;
internal interface IAddable<T>
{
    void Add(T item);
    List<T> GetAllItems();
}

