﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SituationalTriggers : MonoBehaviour
{
    public GameObject Waypoint;
  

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Waypoint.SetActive(false);
            SceneManager.LoadScene(3);
        }
    }
}
