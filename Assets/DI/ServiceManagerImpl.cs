public class ServiceManagerImpl : ServiceManager
{
    private GameService gameService = new GameServiceImpl();
    private NavigatorService navigatorService = new NavigatorServiceImpl();

    public GameService GetGameService()
    {
        return gameService;
    }

    public NavigatorService GetNavigatorService()
    {
        return navigatorService;
    }
}