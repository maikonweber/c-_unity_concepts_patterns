public abstract class PlayerDecorator : MonoBehaviour
{
    protected PlayerController playerController;

    public void SetPlayerController(PlayerController controller)
    {
        playerController = controller;
    }

    public virtual void Move()
    {
        playerController.Move();
    }
}

public class DoubleJumpDecorator : PlayerDecorator
{
    public override void Move()
    {
        playerController.Move();
        PerformDoubleJump();
    }

    private void PerformDoubleJump()
    {
        // Lógica do salto duplo
    }
}

// Outros decoradores...
();

// Adição de efeitos visuais em tempo real:
// O padrão Decorator pode ser usado para adicionar efeitos visuais em tempo real a objetos no Unity. Por exemplo, suponha que você tenha um objeto Projectile que representa um projétil. Você pode usar o padrão Decorator para adicionar efeitos de partículas, rastro de fumaça ou
//  outros efeitos visuais ao objeto do projétil.


public abstract class ProjectileDecorator : MonoBehaviour
{
    protected Projectile projectile;

    public void SetProjectile(Projectile proj)
    {
        projectile = proj;
    }

    public virtual void Update()
    {
        projectile.Update();
    }
}

public class ParticleEffectDecorator : ProjectileDecorator
{
    public override void Update()
    {
        projectile.Update();
        ShowParticleEffect();
    }

    private void ShowParticleEffect()
    {
        // Lógica para exibir efeitos de partículas
    }
}

// Outros decoradores...
