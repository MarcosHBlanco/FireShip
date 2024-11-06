using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;  // Reference to the UI Slider component

    // Method to set the maximum health value (e.g. at the start of the game)
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;  // Set the slider's maximum value
        slider.value = health;     // Set the slider's current value (full health)
    }

    // Method to update the current health on the health bar
    public void SetHealth(int health)
    {
        slider.value = health;  // Update the slider's value to the current health
    }
}
