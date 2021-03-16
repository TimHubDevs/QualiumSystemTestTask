using UnityEngine;

public class DestroyCollider : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Square")
        {
            Destroy(other.gameObject);
        }
    }
}