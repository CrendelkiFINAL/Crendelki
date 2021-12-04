using System.Net.Mime;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayDrone : MonoBehaviour
{

    public Collector smt;
    public float Distance = 10;
    int points = 0;
    private int sec;
    private int min;
    public Text text;
    public Text FinalPoints;
    public GameObject End;
    public GameObject Lose;


    void Start()
    {
       StartCoroutine(TimeFlow());
       StartCoroutine(PointCheck());
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
        if(min >= 10)
        {
            points = points - 3;
            yield return new WaitForSeconds(60);
        }

        if(min >= 25)
        {
            Lose.SetActive(true);
        }
    }
    public void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * Distance, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Distance))
        {
            Selectable selectable = hit.collider.gameObject.GetComponent<Selectable>();
            if (selectable && Input.GetKeyDown(KeyCode.F))
            {
                if (selectable.GetComponent<Renderer>().material.color != Color.red)
                {
                    smt.thereIs++;
                }
                points += 20;
                selectable.Select();
                ScreenCapture.CaptureScreenshot("Screenshot.png");
                Debug.Log(smt.thereIs);
            }

        FinalPoints.text = points.ToString();

        }
    }

    // public void Count(){
    //     if (Update.selectable){

    //     }
    // }
}
