using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //Speed of the enemy sprites.
    private float speed = 250.0f;

    //Checks if enemy has collided with the projectile weapon.
    public void OnTriggerEnter(Collider other)
    {
        //These check if the colour of enemy matches the colour of projectile.
        //If so, the player is given 50 points, and the enemy sprite/ object is destroyed.
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
        //Deletes the enemy sprite if it hits the end boundary.
        if (other.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame.
    void Update()
    {
        //Moves the enemy sprites across the screen.
        transform.Translate(Vector3.right * speed * Time.deltaTime, Space.Self);
    }
}
