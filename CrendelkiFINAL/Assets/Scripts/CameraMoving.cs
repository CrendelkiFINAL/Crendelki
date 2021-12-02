using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    public float turnSpeed = 20000f;

    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
       if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, - turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
    }

}
