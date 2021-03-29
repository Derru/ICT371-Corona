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

    public GameObject Canvas1;
    public GameObject Canvas2;
    public GameObject Risky;
    public GameObject EndScreen;
    public GameObject Safer;

    public GameObject MainCamera;
    public GameObject EndScreenCamera;

    void Awake()
    {
        covidcases.text = covidCases.ToString();
        deathcount.text = deathCount.ToString();
        covidchance.text = covidChance.ToString();
    }
    void Start()
    {
        MainCamera.SetActive(true);
        EndScreen.SetActive(false);
        EndScreenCamera.SetActive(false);
    }

    void Update()
    {
        Abutton();
        Bbutton();

        covidcases.text = covidCases.ToString();
        deathcount.text = deathCount.ToString();
        covidchance.text = covidChance.ToString();
    }
    public void ClickedAButton()
    {
        Canvas1.SetActive(false);
        Canvas2.SetActive(false);
        
        Time.timeScale = 1f;

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

    public void RiskyUI()
    {
        Risky.SetActive(false);
    }

    public void SaferUI()
    {
        Safer.SetActive(false);
    }

    public void Abutton()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            Canvas1.SetActive(false);
            Canvas2.SetActive(false);
            Risky.SetActive(false);
            Safer.SetActive(false);
            Time.timeScale = 1f;

            covidCases = covidCases + 1;
            deathCount = deathCount + 0;
            covidChance = covidChance + 0;
            covidcases.text = covidCases.ToString();
            deathcount.text = deathCount.ToString();
            covidchance.text = covidChance.ToString();
        }
    }

    public void Bbutton()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            Canvas1.SetActive(false);
            Canvas2.SetActive(false);
            Risky.SetActive(false);
            Safer.SetActive(false);
            Time.timeScale = 1f;

            covidCases = covidCases + 1;
            deathCount = deathCount + 0;
            covidChance = covidChance + 0;
            covidcases.text = covidCases.ToString();
            deathcount.text = deathCount.ToString();
            covidchance.text = covidChance.ToString();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("MovementTriggerPositive"))
        {
            covidCases = covidCases + 1;
            deathCount = deathCount + 0;
            covidChance = covidChance + 1;
        }

        if (collision.CompareTag("MovementTriggerNegative"))
        {
            covidCases = covidCases + 30;
            deathCount = deathCount + 3;
            covidChance = covidChance + 1;
        }

        if (collision.CompareTag("Finish"))
        {
            EndScreen.SetActive(true);
            EndScreenCamera.SetActive(true);
        }
    }
}
