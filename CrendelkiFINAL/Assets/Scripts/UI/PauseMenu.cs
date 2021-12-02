 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject MenuPaused;
    public static bool GameIsPaused = false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        MenuPaused.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    public void Pause()
    {
        MenuPaused.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Exit()
    {
        Application.LoadLevel("Menu");
    }
}
