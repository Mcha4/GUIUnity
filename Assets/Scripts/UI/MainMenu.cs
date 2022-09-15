using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject MainMenuUI;
    public GameObject SettingMenuUI;

    // Start is called before the first frame update
    public void Hello()
    {
        Debug.Log("Hello, World");
    }

    // Update is called once per frame
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Hello, World");
    }

    public void Settings()
    {
        Debug.Log("SettingsMenu");
        MainMenuUI.SetActive(false);
        SettingMenuUI.SetActive(true);
    }
    
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
