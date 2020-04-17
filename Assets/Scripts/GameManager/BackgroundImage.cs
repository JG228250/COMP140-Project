using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundImage : MonoBehaviour
{
    private bool imageChosen = false;

    public Sprite back1;
    public Sprite back2;
    public Sprite back3;
    public Sprite back4;
    // Update is called once per frame
    void Update()
    {
        Random rnd = new Random();
        Sprite[] backgrounds = {
        back1,
        back2,
        back3,
        back4
        };
        if (imageChosen == false)
        {
            imageChosen = true;
            this.gameObject.GetComponent<Image>().sprite = backgrounds[Random.Range(0, 4)];
        }
    }
}
