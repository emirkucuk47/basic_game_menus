using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class manager : MonoBehaviour
{

    public GameObject panel_settings;
    

    

    public void Pressed_Play()
    {
        SceneManager.LoadScene("during_game");

    }

    public void Pressed_Settings()
    {
        panel_settings.SetActive(true);
        Time.timeScale = 0f;

    }

    public void Pressed_Quit()
    {
        Application.Quit();

    }

    public void Pressed_Back()
    {
        panel_settings.SetActive(false);

    }

}
