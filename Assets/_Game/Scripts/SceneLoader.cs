using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private List<string> sceneHistory = new List<string>();
    private static SceneLoader s_Instance = null;

    void Awake()
    {
        if (s_Instance == null)
        {
            s_Instance = this;
            DontDestroyOnLoad(gameObject);

            //Initialization code goes here[/INDENT]
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadScene(string sceneName)
    {
        sceneHistory.Add(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(sceneName);
    }

    public void PreviousScene()
    {
        var a = sceneHistory.Count;
        SceneManager.LoadScene(sceneHistory[a-1]);
    }
}
