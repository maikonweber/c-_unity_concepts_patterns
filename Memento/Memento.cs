public class Memento
{
    public string State { get; private set; }

    public Memento(string state)
    {
        State = state;
    }
}


public class Originator
{
    private string state;

    public string State
    {
        get { return state; }
        set { state = value; }
    }

    public Memento CreateMemento()
    {
        return new Memento(state);
    }

    public void RestoreMemento(Memento memento)
    {
        state = memento.State;
    }
}


public class Caretaker
{
    private List<Memento> mementos = new List<Memento>();

    public void AddMemento(Memento memento)
    {
        mementos.Add(memento);
    }

    public Memento GetMemento(int index)
    {
        return mementos[index];
    }
}

// Originator originator = new Originator();
// Caretaker caretaker = new Caretaker();

// // Modifique o estado do objeto
// originator.State = "Estado 1";
// caretaker.AddMemento(originator.CreateMemento());

// // Modifique o estado do objeto novamente
// originator.State = "Estado 2";
// caretaker.AddMemento(originator.CreateMemento());

// // Restaure o estado anterior
// Memento memento = caretaker.GetMemento(0);
// originator.RestoreMemento(memento);
