using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    private SceneLoader _sceneLoader;
    void Start()
    {
        _sceneLoader = GameObject.FindGameObjectWithTag("MainManager").GetComponentInChildren<SceneLoader>();
    }
    public void Back()
    {
        _sceneLoader.LoadScene(Globals._main);
    }

    public void LoadLevel()
    {
        //not the best solution. But easy to debug and cheap by calculations
        //but name has to be in pattern _level_x
        var gameObject = EventSystem.current.currentSelectedGameObject;
        if (gameObject != null)
            _sceneLoader.LoadScene(gameObject.name);
        else
            Debug.Log("LoadLevel go is null");
        
    }
}
