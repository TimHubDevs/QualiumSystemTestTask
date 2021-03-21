using TMPro;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject recordPanel;

    public void StartGame()
    {
        MainDependencyImpl.getInstance().GetServiceManager().GetGameService().StartNewGame();
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ShowRecord()
    {
        recordPanel.SetActive(true);
        recordPanel.GetComponentInChildren<TextMeshProUGUI>().text =
            MainDependencyImpl.getInstance().GetServiceManager().GetGameService().ShowRecord();
    }
}