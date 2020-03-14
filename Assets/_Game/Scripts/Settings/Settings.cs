using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals
{
 
    public static string _main = "_main";
    public static string _options = "_options";
    public static string _levels = "_levels";
    public static string _gameOver = "_gameOver";
    public static string _pause = "_pause";

    public static bool allowDragging;
}

public class Settings : MonoBehaviour
{
    public void DraggingOn(bool value)
    {
        if (value == true)
        {
            Globals.allowDragging = true;
        }
        else
        {
            Globals.allowDragging = false;
        }
    }
}
