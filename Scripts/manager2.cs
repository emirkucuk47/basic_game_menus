using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class manager2 : MonoBehaviour
{

    public GameObject panel_pause;


    private void Start()
    {
        panel_pause.SetActive(false);

    }

    private void Update()
    {
        GameObject.Find("Main Camera").transform.RotateAround(new Vector3(0, 0, -10), new Vector3(-1, 1, 0), -20 * Time.deltaTime);
    }

    public void Pressed_Pause()
    {
        panel_pause.SetActive(true);

    }

    public void Pressed_Continue()
    {
        panel_pause.SetActive(false);

    }

    public void Pressed_MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");

    }

}
