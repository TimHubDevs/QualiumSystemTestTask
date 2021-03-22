using UnityEngine;

public class InitGame : MonoBehaviour
{
    void Start()
    {
        // PlayerPrefs.DeleteAll();
        MainDependencyImpl.getInstance().GetServiceManager().GetGameService().openMenu();
    }
}