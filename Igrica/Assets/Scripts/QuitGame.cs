using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour {

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2.5f, Screen.height / 1.1f, Screen.width / 5, Screen.height / 12), "Quit"))
        {
            Application.LoadLevel("menu");
        }
    }
}
