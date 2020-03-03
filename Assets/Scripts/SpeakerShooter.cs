using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerShooter : MonoBehaviour
{
    public Transform speakerWeapon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(speakerWeapon, transform.position, transform.rotation);
        }
    }
}
