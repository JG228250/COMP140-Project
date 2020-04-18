using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitboxCheck : MonoBehaviour
{
    public enum Hitmarker {Boundary}
    public Hitmarker hitmarkerType;

    public HealthBar healthBar;

    private int maxHealth = 100;
    public int playerHealth;
    private int minHealth = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hitmarkerType == Hitmarker.Boundary && (other.gameObject.tag == "EnemyRed" || other.gameObject.tag == "EnemyGreen" || other.gameObject.tag == "EnemyPurple" || other.gameObject.tag == "EnemyBlue"))
        {
            playerHealth -= 10;
            healthBar.SetHealth(playerHealth);
        }
        if (playerHealth <= minHealth)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
