using UnityEngine;

public class MusicBarTimer : MonoBehaviour
{
    //Initisialises the timer.
    public static float time = 0.0f;
    public float maxTime = 0.5f;
    public float minTime = 0.0f;
    //Reference to the MusicBar.
    public MusicBar musicBar;

    private void Start()
    {
        //Initialises the scene by setting the slider minimum and maximum values.
        musicBar.SetMaxTime(maxTime);
        musicBar.SetMinTime(minTime);
    }
    // Update is called once per frame
    void Update()
    {
        //This is the timer element.
        time += Time.deltaTime;
        //Resets the timer back to 0 when ot hits 0.5 seconds.
        if (time >= maxTime)
        {
            time = 0.0f;
        }
        //Updates the MusicBar with the timer values.
        musicBar.SetTime(time);
    }
}
