public class ParticleFlyweight 
{
    public Color Color { get; set; }
    public float Size { get; set; }
}

public class ParticleFlyweightFactory 
{
    private Dictionary<string, ParticleFlyweight> flyweights = new Dictionary<string, ParticleFlyweight>();

    public ParticleFlyweight GetFlyweight(string key) 
    {
        if (flyweights.ContainsKey(key))
        {
            return flyweights[key];
        }
        else 
        {
            ParticleFlyweight flyweight = new ParticleFlyweight();
    
            flyweight[key] = flyweight;
            return flyweight;
        }
    }
}


public class ParticleManager: MonoBehaviour 
{
    private ParticleFlyweightFactory flyweightFactory = new ParticleFlyweightFactory()


    public void CreateParticle(string key, Vector3 position)
    {
        ParticleFlyweight flyweight = flyweightFactory.GetFlyweight(key);
        Particle particle = new Particle(flyweight, position);

    }
}