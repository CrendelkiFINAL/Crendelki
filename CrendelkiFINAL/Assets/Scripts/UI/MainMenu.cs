using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public void Practice()
    {
        Application.LoadLevel("PracticeLevel");
    }


    public void Exam()
    {
        Application.LoadLevel("ExamLevel");
    }


    public void Educate()
    {
        Application.LoadLevel("EducateLevel");
    }


    public void Exit()
    {
        Application.Quit();
    }
}
