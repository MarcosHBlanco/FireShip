using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Shipcript : MonoBehaviour
{   
    public float maxSpeed;
    float shipBoundaryRadius = 0.5f;
    void Start()
    {
        
    }
    void Update()
    {   
        //Move the ship
        Vector3 pos = transform.position;
        pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
        pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;

        //Restrict player to the camera's boundaries
        //First Y axis boudnaries (simpler)
        if(pos.y + shipBoundaryRadius > Camera.main.orthographicSize){
            pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
        }
        if(pos.y - shipBoundaryRadius < -Camera.main.orthographicSize){
            pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
        }

        //Calculate screen ratio to get X axis boundaries    
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrthographicSize = Camera.main.orthographicSize * screenRatio;

        if(pos.x + shipBoundaryRadius > widthOrthographicSize){
            pos.x = widthOrthographicSize - shipBoundaryRadius;
        }
        if(pos.x - shipBoundaryRadius < -widthOrthographicSize){
            pos.x = -widthOrthographicSize + shipBoundaryRadius;
        }

        transform.position = pos;
    }
}



/* This is the code if i want the ship to rotate (which in this game, i don't);

public floast rotSpeed;

Quaternion rot = transform.rotation;
float z = rot.eulerAngles.z;
z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
rot = Quaternion.Euler(0, 0, z);
transform.rotation = rot;

Vector3 pos = transform.position;
Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);
pos += rot * velocity;
transform.position = pos;
*/
