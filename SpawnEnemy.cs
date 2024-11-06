using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
     public float spawnRate = 1.5f;
    private float timer = 0;
    private float screenTop;
    private float screenBottom;
    public GameObject Enemy;
    void Start()
    {
        Camera cam = Camera.main;
        screenTop = cam.orthographicSize;
        screenBottom = -cam.orthographicSize;
    }
    void Update()
    {
        SpawnEnemys();
    }
    void SpawnEnemys(){
        float lowestPoint = screenBottom;
        float highestPoint = screenTop;

        timer += Time.deltaTime;

        if(timer >= spawnRate ){
            Instantiate(Enemy, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), Quaternion.identity);
            timer = 0;
        }
    }
}
