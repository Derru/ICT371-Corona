using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueScene : MonoBehaviour
{
    public AudioSource audiosr;
    // Start is called before the first frame update
    public void ContinueButton()
    {
        audiosr.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
