﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public float gameOverDelay = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadMainGame", gameOverDelay);
    }

    void LoadMainGame()
    {
        SceneManager.LoadScene(0);
    }
}