using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleСourse : MonoBehaviour
{
    public GameObject late;
    public GameObject thing;
    int x = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Drone")
        {
            x++;
            late.SetActive(false);
            thing.SetActive(true);
        }

    }
}
