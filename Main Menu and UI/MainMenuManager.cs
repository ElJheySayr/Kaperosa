using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MainMenuManager : MonoBehaviour
{
    public static MainMenuManager instance;

    public GameObject panelMain;
    public GameObject panelOptions;
    public GameObject panelAbout;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);

        panelMain.SetActive(true);
        panelOptions.SetActive(false);
        panelAbout.SetActive(false);

        UnityEngine.Cursor.lockState = CursorLockMode.None;
        UnityEngine.Cursor.visible = true;

        RenderSettings.skybox.SetFloat("_Exposure", 0.5f);
    }

    public void _BtnStart()
    {
        UnityEngine.Cursor.lockState = CursorLockMode.None;
        UnityEngine.Cursor.visible = true;

        if(PlayerPrefs.GetInt("LevelIndex") == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if(PlayerPrefs.GetInt("LevelIndex") == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } 
        else if(PlayerPrefs.GetInt("LevelIndex") == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }   
        else if(PlayerPrefs.GetInt("LevelIndex") == 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }   
        else if(PlayerPrefs.GetInt("LevelIndex") == 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }    
        else if(PlayerPrefs.GetInt("LevelIndex") == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
        }     
    }

    public void _BtnOption()
    {
        panelMain.SetActive(false);
        panelOptions.SetActive(true);
        panelAbout.SetActive(false);
    }

    public void _BtnQuit()
    {
        Application.Quit();
    }

    public void _BtnBack()
    {
        panelMain.SetActive(true);
        panelOptions.SetActive(false);
        panelAbout.SetActive(false);
    }

    public void _BtnAbout()
    {
        panelMain.SetActive(false);
        panelOptions.SetActive(false);
        panelAbout.SetActive(true);
    }
}
