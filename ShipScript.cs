using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour
{
    public int maxHealth = 5; 
    private int currentHealth;  
    public HealthBarScript healthBar;  
    public GameObject gameOverPanel;

    void Start()
    {
        currentHealth = maxHealth; 
        healthBar.SetMaxHealth(maxHealth);  
    }

    void OnTriggerEnter2D(Collider2D other)
    {   
        if(!other.CompareTag("Laser")){
            Debug.Log("Trigger!");  // For debugging
            currentHealth--;
            healthBar.SetHealth(currentHealth); 
        }
        if (currentHealth <= 0)
        {
            DestroyShip();  
            GameOver();
        }
    }
    void DestroyShip()
    {
        Debug.Log("Ship destroyed!");
        Destroy(gameObject);  
    }
    public void GameOver(){
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart(){
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
