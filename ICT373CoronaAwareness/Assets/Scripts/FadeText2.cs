using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FadeText2 : MonoBehaviour
{
    public TextMeshProUGUI regionName;

    public GameObject Finish;
    public GameObject SpillMarker;
    public GameObject FinishMarker;
    public GameObject HandSanitiser;
    public GameObject SocialDistance;
    public GameObject DoneForToday;
    public GameObject SocialDistanceNegative;
    public GameObject TheSpill;

    public AudioSource audiosrcc;

    private float fadeTime;
    private bool fadingIn;

    // Start is called before the first frame update
    void Start()
    {
        regionName.CrossFadeAlpha(0, 0.0f, false);
        fadeTime = 0;
        fadingIn = false;
        SpillMarker.SetActive(false);
        FinishMarker.SetActive(false);
        DoneForToday.SetActive(false);

        Finish.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (fadingIn)
        {
            fadeIn();
        }
        else if (regionName.color.a != 0)
        {
            regionName.CrossFadeAlpha(0, 0.5f, false);
        }
    }

    void fadeIn()
    {
        regionName.CrossFadeAlpha(1, 0.5f, false);
        fadeTime += Time.deltaTime;
        if (regionName.color.a == 1 && fadeTime > 1.5f)
        {
            fadingIn = false;
            fadeTime = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MovementTriggerPositive")
        {
            fadingIn = true;
            regionName.text = other.name;

            Destroy(other.gameObject);
        }
        if (other.tag == "MoveTriggerPositive2")
        {
            fadingIn = true;
            regionName.text = other.name;

            Destroy(other.gameObject);
        }
        if (other.tag == "MovementTriggerNeutral")
        {
            fadingIn = true;
            regionName.text = other.name;
            
            Destroy(other.gameObject);
        }
        if (other.tag == "MovementTriggerNegative")
        {
            fadingIn = true;
            regionName.text = other.name;

            Destroy(other.gameObject);
        }
        if(other.tag == "HandSanitiser")
        {
            fadingIn = true;
            regionName.text = other.name;
            audiosrcc.Play();
            Destroy(other.gameObject);
        }
        if (other.tag == "CleanSpill")
        {
            fadingIn = true;
            regionName.text = other.name;
            SpillMarker.SetActive(true);
            Destroy(other.gameObject);
        }
        if (other.tag == "Spill")
        {
            fadingIn = true;
            regionName.text = other.name;
            SpillMarker.SetActive(false);
            Destroy(other.gameObject);
            DoneForToday.SetActive(true);
            TheSpill.SetActive(false);
        }
        if(other.tag == "GoToEnd")
        {
            FinishMarker.SetActive(true);
            Finish.SetActive(true);
        }
        if(other.tag == "Finish")
        {
            Time.timeScale = 0f;
        }
    }
}
