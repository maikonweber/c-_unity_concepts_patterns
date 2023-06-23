public interface IVisitor
{
    void Visit(ElementA elementA);
    void Visit(ElementB elementB);
}


public abstract class Element
{
    public abstract void Accept(IVisitor visitor);
}


public class ElementA : Element
{
    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class ElementB : Element
{
    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}


public class ConcreteVisitor : IVisitor
{
    public void Visit(ElementA elementA)
    {
        Debug.Log("Visitor is visiting Element A");
    }

    public void Visit(ElementB elementB)
    {
        Debug.Log("Visitor is visiting Element B");
    }
}
<!-- 
Element elementA = new ElementA();
Element elementB = new ElementB();

IVisitor visitor = new ConcreteVisitor();

elementA.Accept(visitor);
elementB.Accept(visitor); -->
