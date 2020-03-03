﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerController : MonoBehaviour
{
    private float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Rotate(new Vector3(0, 0, -30 * speed * Time.deltaTime));
        }
        if(Input.GetKey("s"))
        {
            transform.Rotate(new Vector3(0, 0, +30 * speed * Time.deltaTime));
        }
    }
}
