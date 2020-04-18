using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterImage : MonoBehaviour
{
    public Sprite pose1;
    public Sprite pose2;

    private float time = 0.0f;
    // Update is called once per frame
    private void Update()
    {
        Random rnd = new Random();
        Sprite[] poses = {
        pose1,
        pose2
        };
        this.gameObject.GetComponent<Image>().sprite = poses[Random.Range(0, 2)];
    }
}
