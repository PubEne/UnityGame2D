using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
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
