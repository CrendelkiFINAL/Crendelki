using System.Net.Mime;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PracticeScript : MonoBehaviour
{

    public float Distance = 10;
    public GameObject win;
    public Text t;
    int x = 0;

    public void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Distance))
        {
            Selectable selectable = hit.collider.gameObject.GetComponent<Selectable>();
            if (selectable && Input.GetKeyDown(KeyCode.F))
            {
                if (selectable.GetComponent<Renderer>().material.color != Color.red)
                {
                    x++;
                    t.text = x.ToString() + " / 3";
                }
                selectable.Select();

            }

        }

        if (t.text == "3 / 3")
        {
            Winning();
        }
    }

    public void Winning()
    {
        win.SetActive(true);    
    }

    // public void Count(){
    //     if (Update.selectable){

    //     }
    // }
}
