using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    private bool flag = (true);
    public Text myText;
    public GameObject f;
    public int thereIs = 0;
    public int myNumber = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            myText.text = thereIs + "/" + myNumber;
            if (thereIs >= myNumber)
            {
                flag = false;
                f.SetActive(true);
            }
        }

    }
}
