using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] public AudioMixer myAudioMixer;    
    public GameObject MainMenuUI;
    public GameObject SettingsMenuUI;
    public Dropdown resolutionDropdown;
    public Toggle fullscreenToggle;
    public List<ResItem> resolutions = new List<ResItem>();

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
        //Save the options and go back to MainMenu
        //bool Active = false;
        //AccpetButtonText.
        Int32 option = resolutionDropdown.value;
        setResolution(option, fullscreenToggle.isOn);
        SettingsMenuUI.SetActive(false);
        MainMenuUI.SetActive(true);
    }

    public void Apply()
    {
        //Save the options and stay in Settings Menu
        Int32 option = resolutionDropdown.value;        
        setResolution(option, fullscreenToggle.isOn);
    }

    public void Back()
    {
        //Ask save options if there is modification and return to MainMenu
        SettingsMenuUI.SetActive(false);
        MainMenuUI.SetActive(true);
    }

    public void setVolume(float volume)
    {
        myAudioMixer.SetFloat("MasterVolume", Mathf.Log10(volume) * 20);
    }

    public void setResolution(Int32 option, bool fullscreen)
    {
        Screen.SetResolution(resolutions[option].width, resolutions[option].height, fullscreen);
    }
}

[Serializable]
public class ResItem
{
    public int width, height;
}
