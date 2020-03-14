using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OptionsMenu : MonoBehaviour
{
    private SceneLoader _sceneLoader;

    void Start()
    {
        _sceneLoader = GameObject.Find("SceneManager").GetComponent<SceneLoader>();
    }

    public void Option_1()
    {
        Debug.Log("Option_1");
    }

    public void Option_2()
    {
        Debug.Log("Option_1");
    }

    public void Option_3()
    {
        Debug.Log("Option_1");
    }

    public void Back()
    {
        _sceneLoader.PreviousScene();
    }
}
