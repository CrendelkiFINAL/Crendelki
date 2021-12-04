using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int points = 0;
    private int sec;
    private int min;
    public Text text;


    void Start()
    {
       StartCoroutine(TimeFlow());
    }

    IEnumerator TimeFlow()
    {
        while(true)
        {   
            if(sec == 59)
            {
                min += 1;
                sec = -1;
            }
            text.text = min.ToString("D2") + ":" + sec.ToString("D2");
            sec++;
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator PointCheck()
    {
        if(min >= 1)
        {
            points = points + 3;
            yield return new WaitForSeconds(1);
        }
    }
}
