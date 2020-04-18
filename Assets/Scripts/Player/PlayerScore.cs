using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public static int playerScore;
    Text text;
    private void Awake()
    {
        text = GetComponent<Text>();
        playerScore = 0;
    }

    private void Update()
    {
        text.text = "SCORE: " + playerScore;
    }
}
