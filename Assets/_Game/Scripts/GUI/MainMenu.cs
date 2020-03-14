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
        _sceneLoader.LoadScene(Globals._levels);
    }

    public void Options()
    {
          _sceneLoader.LoadScene(Globals._options);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
