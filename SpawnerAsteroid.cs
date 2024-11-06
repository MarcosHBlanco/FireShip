using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAsteroid : MonoBehaviour
{
    public GameObject Asteroid;
    public float spawnRate = 2f;
    private float timer = 0;
    public int asteroidSize;
    public GameObject asteroidSmall;

    void Start()
    {
        
    }

    void Update()
    {
        if (timer < spawnRate){
            timer += Time.deltaTime;
        } else {
            SpawnAsteroid();
            timer = 0;
        }
    }

    void SpawnAsteroid(){
        float lowestPoint = transform.position.y - Camera.main.orthographicSize;
        float highestPoint = transform.position.y + Camera.main.orthographicSize; 

        Instantiate(Asteroid, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(asteroidSize == 2){
            Instantiate(asteroidSmall, transform.position, transform.rotation);
            Instantiate(asteroidSmall, transform.position, transform.rotation);
            
            Destroy(gameObject);
        } else if(asteroidSize == 1){
            Destroy(gameObject);
        }
    }
}
