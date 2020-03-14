using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject OptionsMenu;

    public void Play()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Options()
    {
        OptionsMenu.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
