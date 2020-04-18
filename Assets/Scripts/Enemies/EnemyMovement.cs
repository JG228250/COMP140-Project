using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    private float speed = 250.0f;

    public static int playerScore;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "WeaponRed" && gameObject.tag == "EnemyRed")
        {
            PlayerScore.playerScore += 50;
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "WeaponGreen" && gameObject.tag == "EnemyGreen")
        {
            PlayerScore.playerScore += 50;
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "WeaponPurple" && gameObject.tag == "EnemyPurple")
        {
            PlayerScore.playerScore += 50;
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "WeaponBlue" && gameObject.tag == "EnemyBlue")
        {
            PlayerScore.playerScore += 50;
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime, Space.Self);
    }
}
