using UnityEngine;

public class InitGame : MonoBehaviour
{
    void Start()
    {
        MainDependencyImpl.getInstance().GetServiceManager().GetGameService().openMenu();
    }
}