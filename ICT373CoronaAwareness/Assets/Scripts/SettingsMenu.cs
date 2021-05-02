using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audiomixer;
    public GameObject OptionsMenu;
    public GameObject MainMenu;

    public void SetVolume(float volume)
    {
        audiomixer.SetFloat("volume", volume);
    }

    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void HideOptions()
    {
        OptionsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
}
