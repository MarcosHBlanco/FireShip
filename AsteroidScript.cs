using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public float maxThrust;
    public float maxTorque;
    public Rigidbody2D rb;
    
    public float spawnRate = 2f;
    private float timer = 0;
    private float screenTop;
    private float screenBottom;
    private float screenLeft;
    private float screenRight;
    public int asteroidSize;
    public GameObject Asteroid;
    public GameObject asteroidSmall;
    private int maxAsteroids = 4;
    public float maxSpeed = 0.010f;
    void Start()
    {   
        ApplyRandomForceAndTorque();

        Camera cam = Camera.main;

        screenTop = cam.orthographicSize;
        screenBottom = -cam.orthographicSize;
        screenRight = cam.aspect * cam.orthographicSize;    
        screenLeft = -screenRight;
    }

    void Update()
    {
        HandleSpawning();
        WrapPosition();

        transform.position -= Vector3.right * maxSpeed;
    }

    void WrapPosition(){
        Vector2 newPos = transform.position;

        if(transform.position.y > screenTop){
            newPos.y = screenBottom;
        } else if(transform.position.y < screenBottom){
            newPos.y = screenTop;
        }
        if(transform.position.x > screenRight){
            newPos.x = screenLeft;
        } else if(transform.position.x < screenLeft){
            newPos.x = screenRight;
        }
        transform.position = newPos;    
    }
void SpawnAsteroid(){
        float lowestPoint = screenBottom;
        float highestPoint = screenTop;
        float randomX = Random.Range(screenLeft, screenRight);

        Instantiate(Asteroid, new Vector3(randomX, Random.Range(lowestPoint, highestPoint), 0), Quaternion.identity);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(asteroidSize == 2){
            SplitAsteroid();
        } else if(asteroidSize == 1){
            Destroy(gameObject);
        }
    }
    void ApplyRandomForceAndTorque(){
        Vector2 thrust = new Vector2(Random.Range(-maxThrust, maxThrust), Random.Range(-maxThrust, maxThrust));
        float torque = Random.Range(-maxTorque, maxTorque);

        rb.AddForce(thrust);
        rb.AddTorque(torque);
    }

    void HandleSpawning(){
        timer += Time.deltaTime;
        if (timer >= spawnRate && GameObject.FindGameObjectsWithTag("Asteroid").Length < maxAsteroids){
            SpawnAsteroid();
            timer = 0;
        }
    }
    void SplitAsteroid(){
        Instantiate(asteroidSmall, transform.position, transform.rotation);
        Instantiate(asteroidSmall, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
