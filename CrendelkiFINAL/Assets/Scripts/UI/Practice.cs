using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{

    public void Obstacle()
    {
        //Application.LoadLevel("PracticeLevel");
    }


    public void Town()
    {
        //Application.LoadLevel("ExamLevel");
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
