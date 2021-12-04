using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstMeet : MonoBehaviour
{
    public GameObject meeting;

    void Start()
    {
        meeting.SetActive(true);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            meeting.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
