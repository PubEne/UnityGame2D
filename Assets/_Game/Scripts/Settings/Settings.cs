using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals
{
    public static bool allowDragging;
}

public class Settings : MonoBehaviour
{
    public void Start()
    {

    }

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
