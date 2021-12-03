using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDrone : MonoBehaviour
{
    // public Transform Pointer;
    public float Distance = 10;
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * Distance, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Distance))
        {
            Selectable selectable = hit.collider.gameObject.GetComponent<Selectable>();
            if (selectable && Input.GetKey(KeyCode.F))
            {
                selectable.Select();
                ScreenCapture.CaptureScreenshot("Screenshot.png");
            }
        }

    }
}
