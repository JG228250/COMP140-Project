using UnityEngine;
using UnityEngine.UI;

public class MusicBar : MonoBehaviour
{
    //Reference to the slider element of the MusicBar.
    public Slider slider;
    //Reference to the gradient component, that changes the clour of the fill area.
    public Gradient gradient;
    //Reference to the fill area of the MusicBar.
    public Image fill;

    //Sets the max time that the slider will count up to, in this case it is 0.5 seconds.
    public void SetMaxTime(float time)
    {
        slider.maxValue = time;
        //Sets the fill colour to the gradients maximum value (green).
        fill.color = gradient.Evaluate(1f);
    }

    public void SetMinTime(float time)
    {
        slider.minValue = time;
        slider.value = time;
        //Sets the fill colour to the gradients minimum value (blue).
        fill.color = gradient.Evaluate(0f);
    }

    public void SetTime(float time)
    {
        slider.value = time;
        //Maps the timer to the value of the slider.
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
