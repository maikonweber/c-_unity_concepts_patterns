// Context

public class Player 
{
    private PlayerState currentState;
    public void SetState(PlayerState state)
    {
        currentState = state;
    }

    public void PerformAction()
    {
        currentState.PerformAction();
    }
}

// Estado (State)

public abstract class PlayerState
{
    public abstract void PerformAction()
    {
        // Logica para ação quando jogador está em estado ocioso
    }
}


public class RunningState: PlayerState
{
    public override void PerformAction()
    {
        // Logica correndo;
        
    }
}