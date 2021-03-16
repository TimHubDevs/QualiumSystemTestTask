public class MainDependencyImpl : MainDependencys
{
    private static MainDependencys instance = new MainDependencyImpl();
    private ServiceManager serviceManager;

    public MainDependencyImpl()
    {
        serviceManager = new ServiceManagerImpl();
    }

    public static MainDependencys getInstance()
    {
        if (instance == null)
        {
            instance = new MainDependencyImpl();
        }

        return instance;
    }


    public ServiceManager GetServiceManager()
    {
        return serviceManager;
    }
}