using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void exitGame() {
        //Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
