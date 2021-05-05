using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitTriggers2 : MonoBehaviour
{
    public GameObject UISelect1;
    public GameObject Waypoint;


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
            Waypoint.SetActive(false);
        }
    }
}
