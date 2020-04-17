using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeakerShooter : MonoBehaviour
{
    private Transform speakerWeapon;

    public Transform redAttack;
    public Transform greenAttack;
    public Transform purpleAttack;
    public Transform blueAttack;

    // Update is called once per frame
    void Update()
    {
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
