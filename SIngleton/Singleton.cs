public class SingletonExample : MonoBehaviour
{
    private static SingletonExample instance;
    public static SingletonExample Intance
    {
        get { return instance; }
    }

    private void Awake() {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
        }
    
        instance = this;

        DontDestroyOnLoad(gameObject)
    }
}