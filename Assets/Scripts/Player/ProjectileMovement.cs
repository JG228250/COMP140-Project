using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    //The speed the projectile attacks move at.
    private float speed = 750.0f;
    // A timer.
    private float time = 0.0f;

    // Update is called once per frame
    void Update()
    {
        //This is a timer that starts when the first frame is called, and updates every frame.
        time += Time.deltaTime;
        //This moves the projectile attack in the scene.
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        //This checks how long the projectile object has existed in the scene, to account for them not hitting any other object.
        //If it has existed for more than 4 seconds, it is destroyed, in order to prevent the game loading too many objects.
        if (time > 4.0f)
        {
            Destroy(gameObject);
        }
    }

    //Checks collisions.
    private void OnCollisionEnter(Collision col)
    {
        //If the projectile collides with the end boundary, it is destroyed.
        Destroy(gameObject);
    }

    //Checks collisions.
    private void OnTriggerEnter(Collider other)
    {
        //If the projectile collides with any enemy, it will also be destroyed, no matter if it gives points or not.
        if (other.gameObject.tag == "EnemyRed" || other.gameObject.tag == "EnemyGreen" || other.gameObject.tag == "EnemyPurple" || other.gameObject.tag == "EnemyBlue")
        {
            Destroy(gameObject);
        }
    }
}
