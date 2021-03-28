using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public AudioSource audiosrc;
    public Vector2 InputVector { get; private set; }

    public Vector3 MousePosition { get; private set; }

    private void Awake()
    {
        audiosrc = GetComponent<AudioSource>();
    }

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        InputVector = new Vector2(h, v);
        
        MousePosition = Input.mousePosition;

        if(Time.timeScale < 1f)
        {
            audiosrc.Stop();
        }

        if (v * h > 0)
        {
            if (!audiosrc.isPlaying)
            {
                audiosrc.Play();
                StartCoroutine(Coroutine());
            }
        }         
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSeconds(2);
        audiosrc.Stop();
    }
}
