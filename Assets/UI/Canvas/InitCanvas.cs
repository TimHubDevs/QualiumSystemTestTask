using UnityEngine;

public class InitCanvas : MonoBehaviour
{
    void Start()
    {
        GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceCamera;
        GetComponent<Canvas>().worldCamera = Camera.main;
    }
}