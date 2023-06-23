public class Adapter : ITarget
{
    private Adaptee adaptee;

    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    public void Request()
    {
        adaptee.SpecificRequest();
    }
}


// Adaptee adaptee = new Adaptee();
// ITarget target = new Adapter(adaptee);
// target.Request();