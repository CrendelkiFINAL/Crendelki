using System.Net.Mime;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EducateLast : MonoBehaviour
{

    public float Distance = 10;
    public GameObject won;

    public void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Distance))
        {
            Selectable selectable = hit.collider.gameObject.GetComponent<Selectable>();
            if (selectable && Input.GetKeyDown(KeyCode.F))
            {
                selectable.Select();
                won.SetActive(true);
            }

        }
    }
    // public void Count(){
    //     if (Update.selectable){

    //     }
    // }
}
