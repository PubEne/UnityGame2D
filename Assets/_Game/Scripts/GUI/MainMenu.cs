using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    private SceneLoader _sceneLoader;

    void Start()
    {
        _sceneLoader = GameObject.FindGameObjectWithTag("MainManager").GetComponentInChildren<SceneLoader>();
    }
    
    public void Play()
    {
        _sceneLoader.LoadScene(_sceneLoader._levels.name);
    }

    public void Options()
    {
          _sceneLoader.LoadScene(_sceneLoader._options.name);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
