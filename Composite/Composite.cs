public abstract class Component
{
    public string Name { get; protected set;}

    public virtual void Operation() 
    {
        Debug.Log($"Operation Performed on {Name}");
    }

    public virtual void Add(Component component)
    {
    
    }

    public virtual void Remove(Component component)
    {
    
    }

    public virtual Component GetChild(int index)
    {
        return null;
    }

   }


public class Leaf: Component
    {
    public Leaf(string name) 
    {
    Name = name;
    }
}

public class Leaf : Component
{
    public Leaf(string name)
    {
        Name = name;
    }
}

public class Composite : Component
{
    private List<Component> children = new List<Component>();

    public Composite(string name)
    {
        Name = name;
    }

    public override void Operation()
    {
        Debug.Log($"Operation performed on {Name}");

        // Realize a operação em todos os filhos
        foreach (Component child in children)
        {
            child.Operation();
        }
    }

    public override void Add(Component component)
    {
        children.Add(component);
    }

    public override void Remove(Component component)
    {
        children.Remove(component);
    }

    public override Component GetChild(int index)
    {
        if (index >= 0 && index < children.Count)
        {
            return children[index];
        }
        return null;
    }
}
