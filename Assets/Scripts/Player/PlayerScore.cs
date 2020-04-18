using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    //Sets a class specific variable, that can be accessed from anywhere.
    public static int playerScore;
    //Identifies the text object that the script is a component of, in this case the ScoreText element.
    Text text;

    private void Awake()
    {
        //Sets the text in the class to the text object in the inspector.
        text = GetComponent<Text>();
        //Instantiates the playerScore variable as 0.
        playerScore = 0;
    }

    private void Update()
    {
        //Updates the text with the current player scores, updates every frame.
        text.text = "SCORE: " + playerScore;
    }
}
