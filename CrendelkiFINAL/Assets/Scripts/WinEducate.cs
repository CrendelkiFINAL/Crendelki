using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinEducate : MonoBehaviour
{
    public void Again()
    {
        Application.LoadLevel("Educate");
        Time.timeScale = 1f; 
    }

    public void GoToMenu()
    {
        Application.LoadLevel("Menu");
    }
}
