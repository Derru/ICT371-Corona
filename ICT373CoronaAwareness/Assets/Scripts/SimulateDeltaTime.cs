using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SimulateDeltaTime : MonoBehaviour
{
    private float lastTime;
    private TextMeshProUGUI ps;

    private void Awake()
    {
        ps = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        lastTime = Time.realtimeSinceStartup;
    }

    void Update()
    {
        float deltaTime = Time.realtimeSinceStartup - lastTime;
        ps.CrossFadeAlpha(deltaTime, 0.5f, false);
        lastTime = Time.realtimeSinceStartup;
    }
}
