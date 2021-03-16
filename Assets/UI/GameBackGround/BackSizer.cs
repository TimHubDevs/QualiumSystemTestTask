using UnityEngine;

public class BackSizer : MonoBehaviour
{
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        transform.position = Vector3.zero;
        transform.localScale = new Vector3(1, 1, 1);

        float width = sr.sprite.bounds.size.x;
        float height = sr.sprite.bounds.size.y;

        float variable = Camera.main.orthographicSize * 2;

        float worldScreenHeight = variable;
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        transform.localScale = new Vector3(worldScreenWidth / width, worldScreenHeight / height, 1);
    }
}