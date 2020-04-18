using UnityEngine;
using UnityEngine.UI;

public class CharacterImage : MonoBehaviour
{
    //Reference to the two character sprites that are swapped to create a pseudo animation.
    public Sprite pose1;
    public Sprite pose2;

    // Update is called once per frame
    private void Update()
    {
        //Chooses randomly between the two sprites, to give the illusion the character is moving.
        Random rnd = new Random();
        Sprite[] poses = {
        pose1,
        pose2
        };
        this.gameObject.GetComponent<Image>().sprite = poses[Random.Range(0, 2)];
    }
}
