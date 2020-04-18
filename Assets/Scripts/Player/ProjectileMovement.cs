using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    private float speed = 750.0f;
    private float time = 0.0f;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        if (time > 4.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyRed" || other.gameObject.tag == "EnemyGreen" || other.gameObject.tag == "EnemyPurple" || other.gameObject.tag == "EnemyBlue")
        {
            Destroy(gameObject);
        }
    }
}
