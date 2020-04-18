using UnityEngine;

public class SpeakerShooter : MonoBehaviour
{
    //This is where the projectiles spwn from, in this case the speaker model.
    private Transform speakerWeapon;

    //These are the four weapon colours, that are assigned to the correct prefabs in the inspector.
    public Transform redAttack;
    public Transform greenAttack;
    public Transform purpleAttack;
    public Transform blueAttack;

    // Update is called once per frame
    void Update()
    {
        //This will shoot a certain projectile, depending in the input given.
        if (Input.GetKeyDown("up"))
        {
            speakerWeapon = redAttack;
            Instantiate(speakerWeapon, transform.position, transform.rotation);
        }
        if (Input.GetKeyDown("left"))
        {
            speakerWeapon = greenAttack;
            Instantiate(speakerWeapon, transform.position, transform.rotation);
        }
        if (Input.GetKeyDown("down"))
        {
            speakerWeapon = purpleAttack;
            Instantiate(speakerWeapon, transform.position, transform.rotation);
        }
        if (Input.GetKeyDown("right"))
        {
            speakerWeapon = blueAttack;
            Instantiate(speakerWeapon, transform.position, transform.rotation);
        }
    }
}
