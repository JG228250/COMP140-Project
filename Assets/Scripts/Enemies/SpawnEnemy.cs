using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private float time = 0.0f;
    public Transform enemySpawner;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 1.0f)
        {
            Instantiate(enemySpawner, transform.position, transform.rotation);
            time = 0.0f;
        }
    }
}
