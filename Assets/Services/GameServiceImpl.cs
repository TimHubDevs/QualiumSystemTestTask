using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameServiceImpl : GameService
{
    private GameObject timer;
    private Market market;
    // private List<Plane> planes;

    private NavigatorService getNavigation()
    {
        return MainDependencyImpl.getInstance().GetServiceManager().GetNavigatorService();
    }

    public void openMenu()
    {
        getNavigation().closeAll();
        var menu = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefab/Menu"));
        market = menu.GetComponent<Market>();
        // for (int i = 0; i < planes.Count; i++)
        // {
        //     var marketPlane = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefab/PF_MarketPlane"));
        //     marketPlane.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Sprite/blu-ray");
        //     market.planes.Add(marketPlane.GetComponent<MarketButton>());
        // }
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