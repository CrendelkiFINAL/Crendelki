using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public void Practice()
    {
        Application.LoadLevel("Practice");
    }


    public void Exam()
    {
        Application.LoadLevel("ExamLevel");
    }


    public void Educate()
    {
        Application.LoadLevel("Educate");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
