using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

   // public SceneReference _main;
    public SceneAsset _main;
    public SceneAsset _options;
    public SceneAsset _levels;
    [Space]
    public SceneAsset _level_1;

    private List<string> _sceneHistory = new List<string>();
    private static SceneLoader _sInstance = null;

    void Awake()
    {
        if (_sInstance == null)
        {
            _sInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadScene(string sceneName)
    {
        _sceneHistory.Add(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(sceneName);
    }

    public void PreviousScene()
    {
        SceneManager.LoadScene(_sceneHistory[_sceneHistory.Count-1]);
    }
}
