using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    
    public float speed = 5f;

    private void Start()
    {
         
    }
 
    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.localPosition += transform.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.localPosition += -transform.up * speed * Time.deltaTime;
        }
    }
}
