using UnityEngine;

public class SpeakerController : MonoBehaviour
{
    //Rotation speed for the speaker, (speed to move 20 degrees).
    private float speed = 5.0f;
    
    // Update is called once per frame
    void Update()
    {
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
