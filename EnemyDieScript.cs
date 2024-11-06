using System.Collections;
using System.Collections.Generic;
using UnityEngine;


   public class EnemyDieScript : MonoBehaviour
{
    private UI_Manager uI_Manager;
    public GameObject Enemy;

    public ParticleSystem explosion;

    void Start()
    {
        uI_Manager = GameObject.FindObjectOfType<UI_Manager>();
        explosion = GameObject.FindObjectOfType<ParticleSystem>();
    }

    void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Laser"))
    {
        Debug.Log("Laser hit detected");

        if (uI_Manager != null)
        {
            uI_Manager.AddScore(5);
            Destroy(Enemy);
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }
}

}
