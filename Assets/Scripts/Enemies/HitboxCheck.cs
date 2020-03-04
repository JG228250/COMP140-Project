using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitboxCheck : MonoBehaviour
{
    public enum Hitmarker {Boundary}
    public Hitmarker hitmarkerType;

    public float playerHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (hitmarkerType == Hitmarker.Boundary && other.gameObject.tag == "Enemy")
        {
            playerHealth -= 1;
        }
    }
}
