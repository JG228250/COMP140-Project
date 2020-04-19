using UnityEngine;

public class SpeakerController : MonoBehaviour
{
    //Rotation speed for the speaker, (speed to move 20 degrees).
    private float speed = 5.0f;
    private int rotateValue;
    // Update is called once per frame
    void Update()
    {
        //Retrievs the value of the potentiometer.
        rotateValue = ReadArduinoStrings.potValue;
        //Rotates the speaker clockwise/
        if (rotateValue > 662)
        {
            transform.Rotate(new Vector3(0, 0, -20 * speed * Time.deltaTime));
        }
        //Rotates the speaker counter-clockwise.
        if (rotateValue < 362)
        {
            transform.Rotate(new Vector3(0, 0, +20 * speed * Time.deltaTime));
        }
        
        //Pivots the speaker clockwise.
        if (Input.GetKey("d"))
        {
            transform.Rotate(new Vector3(0, 0, -20 * speed * Time.deltaTime));
        }
        //Pivots the speaker counter-clockwise.
        if(Input.GetKey("a"))
        {
            transform.Rotate(new Vector3(0, 0, +20 * speed * Time.deltaTime));
        }
    }
}
