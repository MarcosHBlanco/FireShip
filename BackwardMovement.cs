using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackwardMovement : MonoBehaviour
{
   public float maxSpeed = 0.010f;

    void Update(){

        transform.position -= Vector3.right * maxSpeed;
        
    }
}
