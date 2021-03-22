using UnityEngine;

public class GameServiceImpl : GameService
{
    private GameObject timer;

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
        timer.GetComponentInChildren<TimerManager>().EndTimer();
        getNavigation().addActionForClose(() => MonoBehaviour.Destroy(askMenu));
    }

    public void StartNewGame()
    {
        getNavigation().closeAll();
        var game = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefab/Game"));
        timer = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefab/Timer"));
        getNavigation().addActionForClose(() =>
        {
            MonoBehaviour.Destroy(game);
            MonoBehaviour.Destroy(timer);
        });
    }

    public void SaveRecord(string value)
    {
        PlayerPrefs.SetString("score", value.Substring(0, 4));
    }

    public string ShowRecord()
    {
        string record = PlayerPrefs.GetString("score");
        return record;
    }
}