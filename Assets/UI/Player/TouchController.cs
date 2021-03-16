using UnityEngine;

public class TouchController : MonoBehaviour
{
    private Camera cam;
    private float halfHeight;
    private float worldScreenWidth;

    void Start()
    {
        cam = Camera.main;
        halfHeight = cam.orthographicSize;
        gameObject.transform.position = new Vector3(0, -3.5f, 0);

        float halfWidth = cam.aspect * halfHeight;

        worldScreenWidth = halfWidth - 1.15f;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var point = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

            if (point.x > 0 && transform.position.x < worldScreenWidth)
            {
                gameObject.transform.position = new Vector3(transform.position.x + 0.85f, -3.5f, 0);
            }
            else if (point.x < 0 && transform.position.x > -worldScreenWidth)
            {
                gameObject.transform.position = new Vector3(transform.position.x - 0.85f, -3.5f, 0);
            }
        }
    }
}