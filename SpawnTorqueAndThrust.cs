using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTorqueAndThrust : MonoBehaviour
{
    public float maxThurst;
    public float maxTorque;
    public Rigidbody2D rb;
    void Start()
    {
        Vector2 thrust = new Vector2(Random.Range(-maxThurst, maxThurst), Random.Range(-maxThurst, maxThurst));
        float torque = Random.Range(-maxTorque, maxTorque);

        rb.AddForce(thrust);
        rb.AddTorque(torque);    
    }
    
    void Update()
    {
        
    }
}
