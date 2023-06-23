public interface IStrategy
{
    void Execute();
}

public class StratefyA : IStrategy
{
    public void Execute()
    {
    
    }
}



public class StratefyB : IStrategy
{
    public void Execute()
    {
    
    }
}

public class StrategyController : MonoBehaviour
{
    private IStrategy currentStrategy;

    public void SetStrategy(IStrategy strategy)
    {
        currentStrategy = strategy;
    }

    public void ExecuteStrategy()
    {
        if (currentStrategy != null)
        {
            currentStrategy.Execute();
        }
    }
}


public class GameManager : MonoBehaviour
{
    public StrategyController strategyController;
    
    // ...

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            IStrategy strategyA = new StrategyA();
            strategyController.SetStrategy(strategyA);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            IStrategy strategyB = new StrategyB();
            strategyController.SetStrategy(strategyB);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            strategyController.ExecuteStrategy();
        }
    }
}
