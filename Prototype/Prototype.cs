public abstract class CharacterPrototype : MonoBehaviour
{
    public abstract CharacterPrototype Clone();
}

public class ElfPrototype: CharacterPrototype
{
    public override CharacterPrototype Clone()
    {
        return Instantiate(this);
    }
}

// CharacterPrototype elfPrototype = new ElfPrototype();

// CharacterPrototype elfClone1 = elfPrototype.Clone();
// CharacterPrototype elfClone2 = elfPrototype.Clone();

// // Modificar as propriedades dos clones conforme necessário
// elfClone1.transform.position = new Vector3(1f, 0f, 0f);
// elfClone2.transform.position = new Vector3(2f, 0f, 0f);
