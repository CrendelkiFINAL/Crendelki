using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamFinal : MonoBehaviour
{

    public GameObject FinalMenu;


    void OnTriggerEnter(Collider other)
    {   

        if(other.tag == "Drone")
        {
            Time.timeScale = 0f;
            FinalMenu.SetActive(true);

        }

    }
}
