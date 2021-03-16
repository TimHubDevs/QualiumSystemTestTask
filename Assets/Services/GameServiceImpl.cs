using UnityEngine;

public class GameServiceImpl : GameService
{
    private NavigatorService getNavigation()
    {
        return MainDependencyImpl.getInstance().GetServiceManager().GetNavigatorService();
    }

    public void openMenu()
    {
        getNavigation().closeAll();
        var menu = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefab/Menu"));
        getNavigation().addActionForClose(() => MonoBehaviour.Destroy(menu));
    }

    public void openAskMenu()
    {
        var askMenu = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefab/AskMenu"));
        getNavigation().addActionForClose(() => MonoBehaviour.Destroy(askMenu));
    }

    public void StartNewGame()
    {
        getNavigation().closeAll();
        var game = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefab/Game"));
        getNavigation().addActionForClose(() => MonoBehaviour.Destroy(game));
    }
}