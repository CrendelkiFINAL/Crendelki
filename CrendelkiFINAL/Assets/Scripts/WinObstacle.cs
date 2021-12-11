using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinObstacle : MonoBehaviour
{
    public void Again()
    {
        Application.LoadLevel("Obstacle Course");
        Time.timeScale = 1f; 
    }

    public void GoToMenu()
    {
        Application.LoadLevel("Menu");
    }
}
