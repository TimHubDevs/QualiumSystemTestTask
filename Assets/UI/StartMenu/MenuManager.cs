using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        MainDependencyImpl.getInstance().GetServiceManager().GetGameService().StartNewGame();
    }

    public void Quit()
    {
        Application.Quit();
    }
}