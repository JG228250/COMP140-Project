using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    //The time that the scene is loaded for, before switching back to the main game scene.
    private float gameOverDelay = 4.5f;

    //Reference to the text elements in the HUD section of the game over menu (assigned within the inspector).
    public Text scoreText;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        //Writes the player's score from the PlayerScore class to the scoreText variable.
        scoreText.text = PlayerScore.playerScore.ToString();
        //Sets the initial highScoreText to 0.
        highScoreText.text = PlayerPrefs.GetInt("highScore", 0).ToString();
        //Runs the SetHighScore function.
        SetHighScore();
        //Pauses for the time stated, then runs the LoadMainGame function.
        Invoke("LoadMainGame", gameOverDelay);
    }

    //Checks if current score is greater than the current high score.
    //If so, it updates the high score, if not the high score stays the same.
    public void SetHighScore()
    {
        if (PlayerScore.playerScore > PlayerPrefs.GetInt("highScore", 0))
        {
            PlayerPrefs.SetInt("highScore", PlayerScore.playerScore);
            highScoreText.text = PlayerScore.playerScore.ToString();
        }
    }

    //Switches from the current GameOver scene (scene 1) to the MainGame scene (scene 0).
    void LoadMainGame()
    {
        SceneManager.LoadScene(0);
    }
}
