using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text covidcases;
    public TMP_Text deathcount;
    public TMP_Text covidchance;

    public int covidCases;
    public int deathCount;
    public double covidChance;

    public GameObject PauseMenu;
    public GameObject Playerrr;

    void Awake()
    {
        DontDestroyOnLoad(Playerrr);
        covidcases.text = covidCases.ToString();
        deathcount.text = deathCount.ToString();
        covidchance.text = covidChance.ToString();
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button7))
        {
            PauseUnpause();
        }

        covidcases.text = covidCases.ToString();
        deathcount.text = deathCount.ToString();
        covidchance.text = covidChance.ToString();
    }

    public void PositiveSelection()
    {
        covidCases = covidCases + 1;
        deathCount = deathCount + 0;
        covidChance = covidChance + 0;
        covidcases.text = covidCases.ToString();
        deathcount.text = deathCount.ToString();
        covidchance.text = covidChance.ToString();
    }
    public void NegativeSelection()
    {
        covidCases = covidCases + 30;
        deathCount = deathCount + 3;
        covidChance = covidChance + 1;
        covidcases.text = covidCases.ToString();
        deathcount.text = deathCount.ToString();
        covidchance.text = covidChance.ToString();
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("MovementTriggerPositive"))
        {
            covidCases = covidCases - 1;
            deathCount = deathCount + 0;
            covidChance = covidChance - 1;
        }

        if (collision.CompareTag("HandSanitiser"))
        {
            covidCases = covidCases - 1;
            deathCount = deathCount + 0;
            covidChance = covidChance - 1;
        }

        if (collision.CompareTag("MovementTriggerNegative"))
        {
            covidCases = covidCases + 33;
            deathCount = deathCount + 4;
            covidChance = covidChance + 1;
        }
    }

    public void QuittheGame()
    {
        Application.Quit();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
    }

    public void PauseUnpause()
    {
        if (!PauseMenu.activeInHierarchy)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
