using UnityEngine;

public class Killer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Circle")
        {
            Destroy(other.gameObject);
            MainDependencyImpl.getInstance().GetServiceManager().GetGameService().openAskMenu();
        }
    }
}