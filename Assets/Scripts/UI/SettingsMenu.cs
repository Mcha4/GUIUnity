using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject MainMenuUI;
    public GameObject SettingsMenuUI;
    
    // Start is called before the first frame update
    void Start()
    {
        SettingsMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Accept()
    {

    }

    public void Apply()
    {

    }

    public void Back()
    {
        MainMenuUI.SetActive(true);

    }
}
