using System.Collections;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    private static Camera cam;
    private float spawnTime = 2;
    private static float speedSpawn;
    private GameObject square;

    void Start()
    {
        cam = Camera.main;
        speedSpawn = 1f;
        StartCoroutine(Spawn());
        StartCoroutine(IncreaseSpeed());
    }

    private IEnumerator Spawn()
    {
        InstantSquare();
        yield return new WaitForSeconds(spawnTime);
        StartCoroutine(Spawn());
    }

    private static void InstantSquare()
    {
        GameObject square =
            Instantiate(Resources.Load("Prefab/Square"), new Vector3(SetX(), 7, 0), Quaternion.identity) as GameObject;
        square.GetComponent<Rigidbody2D>().gravityScale = speedSpawn;
        MainDependencyImpl.getInstance().GetServiceManager().GetNavigatorService()
            .addActionForClose(() => Destroy(square));
    }

    private static float SetX()
    {
        float halfHeight = cam.orthographicSize;
        float halfWidth = cam.aspect * halfHeight;
        float worldScreenWidth = halfWidth - 0.5f;

        float randX = Random.Range(-worldScreenWidth, worldScreenWidth);
        return randX;
    }

    private IEnumerator IncreaseSpeed()
    {
        yield return new WaitForSeconds(5);
        speedSpawn += 1;
        StartCoroutine(IncreaseSpeed());
    }
}