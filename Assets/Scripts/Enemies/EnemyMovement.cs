using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float speed = 250.0f;

    public float playerScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime, Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "WeaponRed" && gameObject.tag == "EnemyRed")
        {
            Destroy(gameObject);
            playerScore += 1;
        }
        if (other.gameObject.tag == "WeaponGreen" && gameObject.tag == "EnemyGreen")
        {
            Destroy(gameObject);
            playerScore += 1;
        }
        if (other.gameObject.tag == "WeaponPurple" && gameObject.tag == "EnemyPurple")
        {
            Destroy(gameObject);
            playerScore += 1;
        }
        if (other.gameObject.tag == "WeaponBlue" && gameObject.tag == "EnemyBlue")
        {
            Destroy(gameObject);
            playerScore += 1;
        }
        if (other.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }
}
