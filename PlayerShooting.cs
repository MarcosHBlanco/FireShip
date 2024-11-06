using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject LaserBean;
    public float fireDelay = 0.25f;
    float cooldownTimer = 0;

    
    void Start()
    {
    GameObject[] allObjects = UnityEngine.GameObject.FindObjectsOfType<GameObject>();
    foreach (GameObject go in allObjects)
    {
        Debug.Log("Active GameObject: " + go.name);
    }
}
    
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if(Input.GetButton("Fire1") && cooldownTimer <= 0){
            cooldownTimer = fireDelay;

            Vector3 offset = new Vector3(1f, 0, 0);

            Instantiate(LaserBean, transform.position + offset, transform.rotation);    
        }
    }
}
