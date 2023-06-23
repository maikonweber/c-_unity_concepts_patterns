public interface IObserver
{
    void OnNotify();
}


public class Subject
{
    private List<IObserver> observers = new List<IObserver>();
    public void RegisterObserver(IObserver observer)
    {
        if(!observers.Contains(observer));
        {
            observers.Add(observer);
        }
    }

    public void RemoveObserver(IObserver observer) 
    {
        if(observers.Contains(observer))
        {
            observers.Remove(observer);
        }
    }    

    public void NotifyObservers()
    {
        foreach(var observer in observers) 
        {
            observer.OnNotify();
        }
    }
}


public class PlayerObserver: IObserver
{
    public void OnNotify()
    {
        Debug.log("Player has been notified of Change")
    }
}
// Sujeito (Subject)
public class Player
{
    // Lista de observadores
    private List<IObserver> observers = new List<IObserver>();

    // Método para adicionar observadores
    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    // Método para remover observadores
    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    // Método para notificar os observadores sobre uma mudança de estado
    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
        {
            observer.Update();
        }
    }

    // Método para simular uma mudança de estado
    public void PlayerStateChanged()
    {
        // Lógica para alterar o estado do jogador

        // Notificar os observadores sobre a mudança de estado
        NotifyObservers();
    }
}

// Observador (Observer)
public interface IObserver
{
    void Update();
}

// Observador Concreto (Concrete Observer)
public class ScoreDisplay : IObserver
{
    public void Update()
    {
        // Lógica para atualizar a exibição do placar
    }
}

// Observador Concreto (Concrete Observer)
public class HealthDisplay : IObserver
{
    public void Update()
    {
        // Lógica para atualizar a exibição da saúde
    }
}
