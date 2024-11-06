using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    float selfDestrucTime = 40f;
    void Update()
    {
        selfDestrucTime -= Time.deltaTime;
        if (selfDestrucTime <= 0){
            Destroy(gameObject);
        }
    }
}
