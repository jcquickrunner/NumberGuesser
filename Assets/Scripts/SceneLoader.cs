﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);

        

    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadStartScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(0);
    }


    /*private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            LoadNextScene();
        }
    }   -------this works-----*/


}


