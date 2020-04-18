using UnityEngine;
using UnityEngine.UI;

public class BackgroundImage : MonoBehaviour
{
    //This bool is used to make sure only one image is chosen for the background, and it doesn't repeatedly swap during runtime.
    private bool imageChosen = false;

    //Reference to all 4 background sprites.
    public Sprite back1;
    public Sprite back2;
    public Sprite back3;
    public Sprite back4;

    // Update is called once per frame
    void Update()
    {
        //Random function, used to randomly pick a background image.
        Random rnd = new Random();
        //An array of all the background images.
        Sprite[] backgrounds = {
        back1,
        back2,
        back3,
        back4
        };
        //Ensures the background does not change.
        if (imageChosen == false)
        {
            imageChosen = true;
            //Selects a random background image from the array.
            //Selects a random background image from the array.
            this.gameObject.GetComponent<Image>().sprite = backgrounds[Random.Range(0, 4)];
        }
    }
}
