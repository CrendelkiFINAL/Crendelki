using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashTrigger : MonoBehaviour
{
    public GameObject Lose;



    void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Drone")
       {
            Lose.SetActive(true);
            Time.timeScale = 0f;  
       }
    }

    public void Exit()
    {
        Application.LoadLevel("Menu");
    }

    public void Again()
    {
        Application.LoadLevel("EducateLevel");
        Time.timeScale = 1f;
    }
}
