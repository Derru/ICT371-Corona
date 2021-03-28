using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SituationalTriggers : MonoBehaviour
{
    public GameObject UISelect1;
    public GameObject Trigger1;
    public GameObject Trigger2;

    // Start is called before the first frame update
    void Start()
    {
        UISelect1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            UISelect1.SetActive(true);
            Trigger1.SetActive(false);
            Time.timeScale = 0f;

            Trigger2.SetActive(false);
        }
    }
}
