using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //Reference to the slider UI object in the scene, assigned in the inspector.
    public Slider slider;
    //Reference to the gradient used to change the colour of teh fill slider.
    public Gradient gradient;
    //Fill image is used to fill the UI health bar slider.
    public Image fill;

    // Instantiates the slider when the game begins, making sure it always begins full.
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        //Changes the colour of the health bar fill to the max gradient value, which in this case is green.
        fill.color = gradient.Evaluate(1f);
    }

    //Sets the slider value to the current health of the player.
    public void SetHealth(int health)
    {
        slider.value = health;
        //Changes the health values from 0-100 to a normalised version (between 0 and 1) in order to map values to the health bar.
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
