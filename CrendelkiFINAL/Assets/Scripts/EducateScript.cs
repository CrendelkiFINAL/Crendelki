using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EducateScript : MonoBehaviour
{
    public GameObject dots;
    public GameObject thing;
    public GameObject Hint;
    public Text t;
    int x = 0;


    void Start()
    {
        
    }

    
    void Update()
    {
        if ((x == 0) & ((Input.GetKeyDown(KeyCode.UpArrow)) || (Input.GetKeyDown(KeyCode.DownArrow)) || (Input.GetKeyDown(KeyCode.RightArrow)) || (Input.GetKeyDown(KeyCode.LeftArrow))))
        {
            t.text = "Отлично! Если ты хочешь взлететь или повернуться то используй клавиши W, A, S, D";
            x++;

        }

        if((x == 1) & ((Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown(KeyCode.D)) || (Input.GetKeyDown(KeyCode.A))))
        {   
                t.text = "Молодец! Теперь попробуй подлететь в указанную точку";
                dots.SetActive(true);
        }

    }

    void OnTriggerEnter(Collider other)
    {   
       
        if(other.tag == "Drone")
        {
            t.text = "Хорошая работа, теперь пролети через сквозь тот обруч, но смотри не задень его!";
            dots.SetActive(false);
            thing.SetActive(true);
        }

    }

}
