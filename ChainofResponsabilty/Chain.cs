public abstract class WeaponEffectHandler
{
    protected WeaponEffectHandler nextHandler;

    public void SetNextHandler(WeaponEffectHandler handler)
    {
        nextHandler = handler;
    }

    public virtual void HandleEffect(Weapon weapon)
    {
        if (nextHandler != null)
        {
            nextHandler.HandleEffect(weapon);
        }
    }
}


public class FireWeaponEffectHandler : WeaponEffectHandler
{
    public override void HandleEffect(Weapon weapon)
    {
        if (weapon.Type == WeaponType.Fire)
        {
            // Realize o processamento específico para o efeito de arma de fogo aqui
            Debug.Log("Efeito de arma de fogo ativado!");
        }
        else
        {
            base.HandleEffect(weapon);
        }
    }
}

public class IceWeaponEffectHandler : WeaponEffectHandler
{
    public override void HandleEffect(Weapon weapon)
    {
        if (weapon.Type == WeaponType.Ice)
        {
            // Realize o processamento específico para o efeito de arma de gelo aqui
            Debug.Log("Efeito de arma de gelo ativado!");
        }
        else
        {
            base.HandleEffect(weapon);
        }
    }
}

// Adicione mais classes concretas para outros efeitos de arma, se necessário
public class Weapon
{
    public WeaponType Type { get; private set; }

    public Weapon(WeaponType type)
    {
        Type = type;
    }

    public void TriggerEffect(WeaponEffectHandler handler)
    {
        handler.HandleEffect(this);
    }
}
