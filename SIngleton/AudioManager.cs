public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    
    // Propriedade para acessar a instância do AudioManager
    public static AudioManager Instance
    {
        get { return instance; }
    }
    
    // Outras variáveis e propriedades para gerenciar o áudio
    
    private void Awake()
    {
        // Verificar se já existe uma instância do AudioManager
        if (instance != null && instance != this)
        {
            // Já existe uma instância, destruir a nova instância
            Destroy(gameObject);
            return;
        }
        
        // Definir a instância do AudioManager
        instance = this;
        
        // Impedir que o objeto do AudioManager seja destruído entre as cenas
        DontDestroyOnLoad(gameObject);
        
        // Inicializar qualquer lógica adicional do AudioManager aqui
    }
    
    // Métodos para controlar o áudio, como reproduzir e parar efeitos sonoros e música de fundo
    public void PlaySoundEffect(AudioClip clip)
    {
        // Lógica para reproduzir o efeito sonoro
    }
    
    public void StopSoundEffect(AudioClip clip)
    {
        // Lógica para parar o efeito sonoro
    }
    
    public void PlayBackgroundMusic(AudioClip clip)
    {
        // Lógica para reproduzir a música de fundo
    }
    
    public void StopBackgroundMusic()
    {
        // Lógica para parar a música de fundo
    }
    
    // Outros métodos e lógica relacionados ao áudio
}
