using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    
    public float speed = 15f;
    public float turnSpeed = 50f;
    public GameObject dron;
    public GameObject camera;
    public GameObject rain;
    public GameObject snow;
    public GameObject choise;
    public Material RainWeather;
    public Material SnowWeather;
    public Material FogWeather;
    public Material GoodWeather;

    void Update()
    {
        GetInput();
        Stabilized();
        
    }

    private void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, - turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }
    }

    private void Stabilized()
    {
        dron.transform.eulerAngles = new Vector3(0, dron.transform.eulerAngles.y, 0);
    }

    public void Rain()
    {
        RenderSettings.skybox = RainWeather;
        rain.SetActive(true);
        choise.SetActive(false);
    }

    public void Snow()
    {
        RenderSettings.skybox = SnowWeather;
        snow.SetActive(true);
        choise.SetActive(false);
    }

    public void NiceWeather()
    {
        RenderSettings.skybox = GoodWeather;
        choise.SetActive(false);
    }

    public void Fog()
    {
        RenderSettings.skybox = FogWeather;
        RenderSettings.fog = true;
        choise.SetActive(false);
    }

    public void goBack()
    {
        Application.LoadLevel("Menu");
    }
}
