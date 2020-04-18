using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private float time = 0.0f;
    //This is used to spawn the enemies in, and subsequently move them accross the screen.
    private Transform enemySpawner;

    //These are assigned to the Enemy sprites within the inspector.
    public Transform redEnemy;
    public Transform greenEnemy;
    public Transform purpleEnemy;
    public Transform blueEnemy;

    // Update is called once per frame
    void Update()
    {
        //This instantiates the random function.
        Random rnd = new Random();
        //This is a timer that starts when the first frame is called, and updates every frame.
        time += Time.deltaTime;
        //This if loop makes sure enemies only spwan between a certain time range, in this case 3 - 50 seconds.
        if (time >= Random.Range(3, 51))
        {
            //Creates an array of Transforms, for use in the random function.
            Transform[] enemies = {
            redEnemy,
            greenEnemy,
            purpleEnemy,
            blueEnemy
            };
            //Assigns a random enemy sprite to the enemy spawner (This changes every frame).
            enemySpawner = enemies[Random.Range(0, 4)];
            //Spawns in the enemies.
            Instantiate(enemySpawner, transform.position, transform.rotation);
            //Resets the timer.
            time = 0.0f;
        }
    }
}
