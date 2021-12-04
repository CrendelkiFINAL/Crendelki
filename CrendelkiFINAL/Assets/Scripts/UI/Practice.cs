using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{

    public void Obstacle()
    {
        Application.LoadLevel("Obstacle Course");
    }

    public void Town()
    {
        Application.LoadLevel("City");
    }

    public void Road()
    {
        Application.LoadLevel("RoadLevel");
    }

    public void Back()
    {
        Application.LoadLevel("Menu");
    }
}
