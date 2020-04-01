using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public static bool Paused = false;
    public GameObject pausedMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
   public void Resume ()
    {
        pausedMenu.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }
   void Pause()
    {
        pausedMenu.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;

    }
    public void LoadMenu ()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void Quit ()
    {
        Application.Quit();
    }
}
