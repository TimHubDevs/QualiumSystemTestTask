using UnityEngine;

public class AskMenuManager : MonoBehaviour
{
    [SerializeField] public GameObject newRecText;
    public void Restart()
    {
        var prevGame = GameObject.Find("Game(Clone)");
        Destroy(prevGame);
        MainDependencyImpl.getInstance().GetServiceManager().GetGameService().StartNewGame();
    }

    public void No()
    {
        MainDependencyImpl.getInstance().GetServiceManager().GetGameService().openMenu();
    }
}