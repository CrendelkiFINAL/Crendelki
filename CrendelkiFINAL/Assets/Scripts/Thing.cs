using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Thing : MonoBehaviour
{
    public GameObject thing;
    public GameObject win;
    public GameObject hint;
    public Text t;
    

    void Start()
    {
        
    }

    
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

    if((other.tag == "Drone"))
    {
        win.SetActive(true);
        t.text = "Все, теперь тебе остается только практиковаться. Удачных полетов!";
        thing.SetActive(false);
        hint.SetActive(false);
    }
    }
}
