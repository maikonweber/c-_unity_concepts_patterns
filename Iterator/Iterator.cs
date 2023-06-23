public interface IIterator<T>
{
    bool HasNext();
    T Next();
}

public class ConcreteIterator<T> : IIterator<T>
{
    private List<T> collection;
    private int position = 0;

    public ConcreteIterator(List<T> collection)
    {
        this.collection = collection;
    }

    public bool HasNext()
    {
        return position < collection.Count;
    }

    public T Next()
    {
        T item = collection[position];
        position++;
        return item;
    }
}

public class Collection<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public IIterator<T> CreateIterator()
    {
        return new ConcreteIterator<T>(items);
    }
}


// Collection<string> collection = new Collection<string>();
// collection.AddItem("Item 1");
// collection.AddItem("Item 2");
// collection.AddItem("Item 3");

// IIterator<string> iterator = collection.CreateIterator();
// while (iterator.HasNext())
// {
//     string item = iterator.Next();
//     Debug.Log("Item: " + item);
// }
