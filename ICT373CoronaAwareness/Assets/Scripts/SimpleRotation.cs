using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotation : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(10, 5, 20) * Time.deltaTime);
    }
}
