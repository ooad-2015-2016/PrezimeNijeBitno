using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour
{

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2.5f, Screen.height / 3, Screen.width / 5, Screen.height / 10), "Start"))
        {
            Application.LoadLevel("Scene_1");
        }
        if (GUI.Button(new Rect(Screen.width / 2.5f, Screen.height / 2, Screen.width / 5, Screen.height / 10), "Options"))
        {
            Application.LoadLevel("Options");
        }

        if (GUI.Button(new Rect(Screen.width / 2.5f, Screen.height / 1.5f, Screen.width / 5, Screen.height / 10), "Quit"))
        {
            Application.Quit();
        }
    }
}