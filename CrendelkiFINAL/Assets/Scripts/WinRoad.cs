using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinRoad : MonoBehaviour
{
    public void Again()
    {
        Application.LoadLevel("RoadLevel");
    }

    public void GoToMenu()
    {
        Application.LoadLevel("Menu");
    }
}
