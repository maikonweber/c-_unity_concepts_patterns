public interface ISubject
{
    void Request();
}

public class RealSubject: ISubject
{
    public void Request() 
    {
        Debug.Log("RealSubject");
    }
}


public class Proxy: ISubject
{
    private RealSubject realSubject;

    public void Request()
    {
        if(realSubject == null)
        {
            realSubject = new RealSubject();
        }
       Debug.Log("Proxy: Performing additional actions before the request.");
       realSubject.Request();
       Debug.Log("Proxy: Performing additional actions after the request.");
               
    }

}