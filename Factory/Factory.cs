public abstract class Enemy
{
    public abstract void Attack();
}


public class Zombie : Enemy 
{
    public override void Attack()
    {
        throw new System.NotImplementedException()
    }
}


public class Skeleton : Enemy 
{
    public override void Attack()
    {
        throw new System.NotImplementedException();
    }
}


public class EnemyFactory 
{
    public Enemy CreateEnemy(string enemyType)
    {
        switch(enemyType){
            case "Zombie":
                return new Zombie();
            case "Skeleton":
                return new Skeleton();
            default:
                throw new ArgumentException("Invalid enemy");
        }
    }
}

public class GameManager : MonoBehaviour
{
    private EnemyFactory enemyFactory = new EnemyFactory();

    private void Start() 
    {
        Enemy zombie = enemyFactory.CreateEnemy("Zombie");
        Enemy skeleton = enemyFactory.CreateEnemy("Skeleton");

        zombie.Attack();
        skeleton.Attack();
    }
}