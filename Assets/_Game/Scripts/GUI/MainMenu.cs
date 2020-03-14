﻿using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField, NotNull]
    private SceneLoader sceneLoader;

    public void Play()
    {
        sceneLoader.LoadScene("GameScene");
    }

    public void Options()
    {
        sceneLoader.LoadScene("OptionsScene");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
