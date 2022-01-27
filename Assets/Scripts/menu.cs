using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    [Header("UIPages")]
    public GameObject soundOn;
    public GameObject soundOff;
    public void start()
    {
        SceneManager.LoadScene("Start");
    }
    public void quit()
    {
        Application.Quit();
    }
    public void sound(string Sound)
    {
        if (Sound=="on")
        {
            soundOn.SetActive(false);
            soundOff.SetActive(true);
            PlayerPrefs.SetInt("sound", 1);
        }
        else if (Sound=="off")
        {
            soundOn.SetActive(true);
            soundOff.SetActive(false);
            PlayerPrefs.SetInt("sound", 0);
        }
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("sound")==0)
        {
            soundOn.SetActive(true);
            soundOff.SetActive(false);
        }
        else
        {
            soundOn.SetActive(false);
            soundOff.SetActive(true);
        }
    }
}
