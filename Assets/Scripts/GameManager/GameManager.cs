using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameOver = false;

    public void GameOver()
    {
        if (gameOver == false)
        {
            gameOver = true;
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
