using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private float time = 0.0f;
    public Transform enemySpawner;

    public Transform redEnemy;
    public Transform greenEnemy;
    public Transform purpleEnemy;
    public Transform blueEnemy;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Random rnd = new Random();
        time += Time.deltaTime;
        if (time >= Random.Range(1, 11))
        {
            Transform[] enemies = {
            redEnemy,
            greenEnemy,
            purpleEnemy,
            blueEnemy
            };
            enemySpawner = enemies[Random.Range(0, 4)];
            Instantiate(enemySpawner, transform.position, transform.rotation);
            time = 0.0f;
        }
    }
}
