using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacles;
    public float spawnRate = 2;
    private float timer = 0;

    public float speed = 1f;
    public Vector2 pointA;
    public Vector2 pointB;
    // Start is called before the first frame update
    void Start()
    {
        spawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        //float time = Mathf.PingPong(Time.time * speed, 1);
        //transform.position = Vector2.Lerp(pointA, pointB, time);

        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnObject();
            timer = 0;
        }
    }

    void spawnObject()
    {
        int i = Random.Range(0, obstacles.Length);
        Instantiate(obstacles[i], new Vector3(transform.position.x, Random.Range(pointA.y, pointB.y), transform.position.z), transform.rotation);
    }
}
