public interface IImplementor
{
    void OperationImpl();
}

public class ConcreteImplementorA : IImplementor
{
    public void OperationImpl()
    {
        Debug.Log("Concrete Implementor A operation");
    }
}

public class ConcreteImplementorB : IImplementor
{
    public void OperationImpl()
    {
        Debug.Log("Concrete Implementor B operation");
    }
}


public abstract class Abstraction
{
    protected IImplementor implementor;

    public Abstraction(IImplementor implementor)
    {
        this.implementor = implementor;
    }

    public abstract void Operation();
}


public class ConcreteAbstractionA : Abstraction
{
    public ConcreteAbstractionA(IImplementor implementor) : base(implementor)
    {
    }

    public override void Operation()
    {
        implementor.OperationImpl();
    }
}

public class ConcreteAbstractionB : Abstraction
{
    public ConcreteAbstractionB(IImplementor implementor) : base(implementor)
    {
    }

    public override void Operation()
    {
        implementor.OperationImpl();
    }
}
