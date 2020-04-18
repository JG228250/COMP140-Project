using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public float gameOverDelay = 3f;

    public Text scoreText;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = PlayerScore.playerScore.ToString();
        highScoreText.text = PlayerPrefs.GetInt("highScore", 0).ToString();
        SetHighScore();
        Invoke("LoadMainGame", gameOverDelay);
    }

    public void SetHighScore()
    {
        if (PlayerScore.playerScore > PlayerPrefs.GetInt("highScore", 0))
        {
            PlayerPrefs.SetInt("highScore", PlayerScore.playerScore);
            highScoreText.text = PlayerScore.playerScore.ToString();
        }
    }

    void LoadMainGame()
    {
        SceneManager.LoadScene(0);
    }
}
