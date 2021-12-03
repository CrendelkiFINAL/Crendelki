using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCameraFollow : MonoBehaviour
{
    public GameObject drone;

    public float distance = 100;
    void LateUpdate()
    {
        transform.position = drone.transform.position + Vector3.up * distance;
    }
}
