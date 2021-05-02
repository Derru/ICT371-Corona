using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject OptionsMenu;
    public GameObject MainMenuu;
    // Start is called before the first frame update
   public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ShowOptions()
    {
        OptionsMenu.SetActive(true);
        MainMenuu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
