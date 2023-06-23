
// Criação de uma classe base para personagem:

public class Character 
{
    // Propriedades do Persongem
    public string Name { get; set;}
    public int Level { get; set;}
    

    public void DisplayInfo() 
    {
        Debug.Log("Name: " + Name + ", Level: " + Level);
    }
}


// Criando uma interface para class abstrata para Bulder 

public interface ICharacterBuilder
{
    void setName(string name);
    void setLevel(int level);

    Character GetCharacter();

}

public class BasicCharacterBuilder : ICharacterBuilder
{
    private Character character;
    public BasicCharacterBuilder()
    {
        character = new Character();
    }

    public void SetName(string name)
    {
        character.Name = name;
    }

    public void SetLevel(int level)
    { 
        character.Level = level;
    }

    public Character GetCharacter()
    {
        return character;
    }
}


public class CharacterDirector 
{
    public Character BuildCharacter(ICharacterBuilder builder, string name, int level)
    {
        builder.SetName(name);
        builder.SetLevel(level);
        return builder.GetCharacter();
    }    
}

// CharacterDirector director = new CharacterDirector();
// ICharacterBuilder builder = new BasicCharacterBuilder();

// Character basicCharacter = director.BuildCharacter(builder, "John", 1);
// basicCharacter.DisplayInfo();
