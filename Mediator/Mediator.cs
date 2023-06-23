public interface IMediator
{
    void SendMessage(string message, Colleague colleague);
}

public class ConcreteMediator : IMediator
{
    private ColleagueA colleagueA;
    private ColleagueB colleagueB;

    public void SetColleagueA(ColleagueA colleague)
    {
        colleagueA = colleague;
    }

    public void SetColleagueB(ColleagueB colleague)
    {
        colleagueB = colleague;
    }

    public void SendMessage(string message, Colleague colleague)
    {
        if (colleague == colleagueA)
        {
            colleagueB.ReceiveMessage(message);
        }
        else if (colleague == colleagueB)
        {
            colleagueA.ReceiveMessage(message);
        }
    }
}


public abstract class Colleague
{
    protected IMediator mediator;

    public void SetMediator(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public abstract void SendMessage(string message);
    public abstract void ReceiveMessage(string message);
}

public class ColleagueA : Colleague
{
    public override void SendMessage(string message)
    {
        mediator.SendMessage(message, this);
    }

    public override void ReceiveMessage(string message)
    {
        Debug.Log("Colleague A received message: " + message);
    }
}

public class ColleagueB : Colleague
{
    public override void SendMessage(string message)
    {
        mediator.SendMessage(message, this);
    }

    public override void ReceiveMessage(string message)
    {
        Debug.Log("Colleague B received message: " + message);
    }
}


// ConcreteMediator mediator = new ConcreteMediator();

// ColleagueA colleagueA = new ColleagueA();
// ColleagueB colleagueB = new ColleagueB();

// colleagueA.SetMediator(mediator);
// colleagueB.SetMediator(mediator);

// mediator.SetColleagueA(colleagueA);
// mediator.SetColleagueB(colleagueB);

// colleagueA.SendMessage("Hello from Colleague A");
// colleagueB.SendMessage("Hi from Colleague B");
