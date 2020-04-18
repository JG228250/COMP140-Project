using UnityEngine;

public class HitboxCheck : MonoBehaviour
{
    //Finds the end boundary and sets it as an enumerator.
    public enum Hitmarker {Boundary}
    //Used for checking the collsions.
    public Hitmarker hitmarkerType;
    //Reference to the health bar, in order to assign the playerHealth values to it.
    public HealthBar healthBar;

    //Maximum health the player can have.
    private int maxHealth = 100;
    //Current player health, used with the health bar.
    public int playerHealth;
    //Minimum health the player can have, when this is reached the player is dead.
    private int minHealth = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Begins every game with full health.
        playerHealth = maxHealth;
        //Ensures the maximum health the health bar can show is the maximum assigned health sbove (100).
        healthBar.SetMaxHealth(maxHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Checks if an enemy has hit the player.
        if (hitmarkerType == Hitmarker.Boundary && (other.gameObject.tag == "EnemyRed" || other.gameObject.tag == "EnemyGreen" || other.gameObject.tag == "EnemyPurple" || other.gameObject.tag == "EnemyBlue"))
        {
            //Removes 10 from the maximum 100 health points (takes away 1/10 of the player's health).
            playerHealth -= 10;
            //Updates the health bar with the new playerHealth value.
            healthBar.SetHealth(playerHealth);
        }
        //Runs the GameOver function when the player's health reaches 0.
        if (playerHealth <= minHealth)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
