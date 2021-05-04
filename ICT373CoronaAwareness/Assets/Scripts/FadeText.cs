using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FadeText : MonoBehaviour
{
    public TextMeshProUGUI regionName;

    public GameObject MaskTrigger;
    public GameObject DetourTrigger;
    public GameObject DetourNegative;
    public GameObject DetourPositive;
    public GameObject faceMask;
    public GameObject faceMaskPickup;
    private float fadeTime;
    private bool fadingIn;

    // Start is called before the first frame update
    void Start()
    {
        regionName.CrossFadeAlpha(0, 0.0f, false);
        fadeTime = 0;
        fadingIn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (fadingIn)
        {
            fadeIn();
        }
        else if(regionName.color.a != 0)
        {
            regionName.CrossFadeAlpha(0, 0.5f, false);
        }
    }

    void fadeIn()
    {
        regionName.CrossFadeAlpha(1, 0.5f, false);
        fadeTime += Time.deltaTime;
        if(regionName.color.a ==1 && fadeTime > 1.5f)
        {
            fadingIn = false;
            fadeTime = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "MovementTriggerPositive")
        {
            fadingIn = true;
            regionName.text = other.name;

            Destroy(other.gameObject);

            faceMask.gameObject.SetActive(true);
            faceMaskPickup.gameObject.SetActive(false);
        }
        if(other.tag == "MoveTriggerPositive2")
        {
            fadingIn = true;
            regionName.text = other.name;

            Destroy(other.gameObject);
        }
        if(other.tag == "MovementTriggerNeutral")
        {
            fadingIn = true;
            regionName.text = other.name;

            Destroy(other.gameObject);
        }
        if(other.tag == "MovementTriggerNegative")
        {
            fadingIn = true;
            regionName.text = other.name;

            Destroy(other.gameObject);
        }
    }
}
