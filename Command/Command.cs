public interface ICommand
{
    void Execute();
    void Undo();

}

public class JumpCommand : ICommand
{
    private Player player;
    public JumpCommand(Player player)
    {
        this.player = player;
    }

    public void Execute() 
    {
        player.Jump();
    }

    public void Undo() 
    {
        // Implemente a logica de desfazer o salto
    }
}

public class AttackCommand: ICommand
{
    private Player player;

    public AttackCommand(Player player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.Attack();
    }

    public void Undo()
    {
    
    }
}


public class CommandInvoker 
{
    private Stack<ICommand> executedCommand = new Stack<ICommand>();

    public void executedCommand(ICommand command)
    {
        command.Execute();
        executedCommand.Push(command);
    }

    public void UndoLastCommand() {
        if(executedCommand.Count > 0) {
            ICommand lastCommand = executedCommand.Pop();
            lastCommand.Undo();
        }
    }
}

public class PlayerInput : MonoBehaviour
{
    public CommandInvoker commandInvoker;

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ICommand jumpCommand = new JumpCommand(player);
            commandInvoker.executedCommand(jumpCommand);
        }
    }
}