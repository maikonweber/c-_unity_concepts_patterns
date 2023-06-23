public abstract class AbstractClass
{
    public void TemplateMethod()
    {
        Step1();
        Step2();
        Step3();
    }

    protected abstract void Step1();
    protected abstract void Step2();
    protected abstract void Step3();
}

public class ConcreteClassA : AbstractClass
{
    protected override void Step1()
    {
        Debug.Log("ConcreteClassA: Step1");
    }

    protected override void Step2()
    {
        Debug.Log("ConcreteClassA: Step2");
    }

    protected override void Step3()
    {
        Debug.Log("ConcreteClassA: Step3");
    }
}

public class ConcreteClassB : AbstractClass
{
    protected override void Step1()
    {
        Debug.Log("ConcreteClassB: Step1");
    }

    protected override void Step2()
    {
        Debug.Log("ConcreteClassB: Step2");
    }

    protected override void Step3()
    {
        Debug.Log("ConcreteClassB: Step3");
    }
}
