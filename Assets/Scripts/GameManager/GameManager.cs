using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Used to ensure the game over scene is only loaded once.
    private bool gameOver = false;

    public void GameOver()
    {
        //Loads the game over scene, only once.
        if (gameOver == false)
        {
            gameOver = true;
            Restart();
        }
    }

    //Loads the game over scene (scene 1).
    void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
