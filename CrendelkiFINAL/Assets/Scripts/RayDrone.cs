using System.Net.Mime;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDrone : MonoBehaviour
{

    public Collector smt;
    public float Distance = 10;
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
                selectable.Select();
                ScreenCapture.CaptureScreenshot("Screenshot.png");
                Debug.Log(smt.thereIs);
            }

        }
    }

    // public void Count(){
    //     if (Update.selectable){

    //     }
    // }
}
