using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMotion : MonoBehaviour
{

    public float maxSpeed = 6f;
    void Update()
    {
        transform.position += (Vector3.right * maxSpeed);
        
    }
}
