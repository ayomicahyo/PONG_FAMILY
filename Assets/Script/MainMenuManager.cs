using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject typeGameplay;

    public void OpenTypeGameplay()
    {
        if(mainMenu.active == true)
        {
            typeGameplay.SetActive(true);
            mainMenu.SetActive(false);
        }
    }

    public void GameplayInOnePhone()
    {
        SceneManager.LoadScene("PlayerSet");
    }

    public void BackButton()
    {
        if(typeGameplay.active == true)
        {
            mainMenu.SetActive(true);
            typeGameplay.SetActive(false);
        }
    }
}
