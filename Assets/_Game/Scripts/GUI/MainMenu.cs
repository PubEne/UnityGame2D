using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    private SceneLoader _sceneLoader;

    void Start()
    {
        _sceneLoader = GameObject.FindGameObjectWithTag("MainManager").GetComponentInChildren<SceneLoader>();
    }

    public void LoadPreviousScene()
    {
        _sceneLoader.PreviousScene();
    }

    public void LoadMainMenuScene()
    {
        _sceneLoader.LoadScene(Globals._main);
    }

    public void LoadOptionsScene()
    {
        _sceneLoader.LoadScene(Globals._options);
    }

    public void LoadLevelsScene()
    {
        _sceneLoader.LoadScene(Globals._levels);
    }

    public void LoadLevelScene()
    {
        //not the best solution. But easy to debug and cheap by calculations
        //but name has to be in pattern _level_x
        var gameObject = EventSystem.current.currentSelectedGameObject;
        if (gameObject != null)
            _sceneLoader.LoadScene(gameObject.name);
        else
            Debug.Log("LoadLevel go is null");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
