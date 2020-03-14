using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OptionsMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject MainMenu;

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
        MainMenu.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
