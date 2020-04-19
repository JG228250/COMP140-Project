using UnityEngine;

public class SpeakerShooter : MonoBehaviour
{
    //This is where the projectiles spwn from, in this case the speaker model.
    private Transform speakerWeapon;

    //These are the four weapon colours, that are assigned to the correct prefabs in the inspector.
    public Transform redAttack;
    public Transform greenAttack;
    public Transform purpleAttack;
    public Transform blueAttack;

    private float comboTime = 0.4f;

    // Update is called once per frame
    void Update()
    {
        //This will shoot a certain projectile, depending in the input given.
        if (Input.GetKeyDown("up"))
        {
            RedWeapon();
        }
        if (Input.GetKeyDown("left"))
        {
            GreenWeapon();
        }
        if (Input.GetKeyDown("down"))
        {
            PurpleWeapon();
        }
        if (Input.GetKeyDown("right"))
        {
            BlueWeapon();
        }
    }

    public void RedWeapon()
    {
        speakerWeapon = redAttack;
        Instantiate(speakerWeapon, transform.position, transform.rotation);
        if (MusicBarTimer.time >= comboTime)
        {
            EnemyMovement.hitPoints *= 2;
        }
        else
        {
            EnemyMovement.hitPoints = 10;
        }
    }

    public void GreenWeapon()
    {
        speakerWeapon = greenAttack;
        Instantiate(speakerWeapon, transform.position, transform.rotation);
        if (MusicBarTimer.time >= comboTime)
        {
            EnemyMovement.hitPoints *= 2;
        }
        else
        {
            EnemyMovement.hitPoints = 10;
        }
    }

    public void PurpleWeapon()
    {
        speakerWeapon = purpleAttack;
        Instantiate(speakerWeapon, transform.position, transform.rotation);
        if (MusicBarTimer.time >= comboTime)
        {
            EnemyMovement.hitPoints *= 2;
        }
        else
        {
            EnemyMovement.hitPoints = 10;
        }
    }

    public void BlueWeapon()
    {
        speakerWeapon = blueAttack;
        Instantiate(speakerWeapon, transform.position, transform.rotation);
        if (MusicBarTimer.time >= comboTime)
        {
            EnemyMovement.hitPoints *= 2;
        }
        else
        {
            EnemyMovement.hitPoints = 10;
        }
    }
}
