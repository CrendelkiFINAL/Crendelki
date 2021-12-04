using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EducateScript : MonoBehaviour
{
    public GameObject dots;
    public GameObject thing;
    public GameObject Hint;
    public GameObject Thats;
    public GameObject win;
    public Text t;
    int x = 0;

    
    void Update()
    {
        if ((x == 0) & ((Input.GetKeyDown(KeyCode.UpArrow)) || (Input.GetKeyDown(KeyCode.DownArrow)) || (Input.GetKeyDown(KeyCode.RightArrow)) || (Input.GetKeyDown(KeyCode.LeftArrow))))
        {
            t.text = "Отлично! Если ты хочешь взлететь или повернуться, то используй клавиши (W, A, S, D)";
            x++;
        }

        if((x == 1) & ((Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown(KeyCode.D)) || (Input.GetKeyDown(KeyCode.A))))
        {   
            t.text = "Молодец! Теперь попробуй подлететь к указаннной точке";
            dots.SetActive(true);
            x++;
        }

    }

    void OnTriggerEnter(Collider other)
    {   
       
        if(other.tag == "Drone")
        {
            t.text = "Хорошая работа, теперь пролети сквозь тот обруч, но смотри не задень его!";
            x++;
            dots.SetActive(false);
            thing.SetActive(true);
        }

        if(other.tag == "Piller")
        {
            t.text = "Отлично. Теперь тебе предстоит найти поломку на столбах. Когда найдёшь её, наведись и нажми кнопку F, чтобы отметить её обнаружение. Подсказка: поломка для удобства заменена на металлический шар";
            thing.SetActive(false);
            Thats.SetActive(true);
        }

    }

    public void Again()
    {
        Application.LoadLevel("Educate");
    }

    public void GoToMenu()
    {
        Application.LoadLevel("Menu");
    }

    public void Won()
    {
        win.SetActive(true);
    }


}
