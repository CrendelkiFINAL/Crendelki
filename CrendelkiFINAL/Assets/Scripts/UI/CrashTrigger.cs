using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashTrigger : MonoBehaviour
{
    public GameObject Lose;

    void OnTriggerEnter(Collider other)
    {
       if(other.tag == "let")
       {
            Lose.SetActive(true);
            Time.timeScale = 0f;  
       }
    }
}
