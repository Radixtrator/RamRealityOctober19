using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phoneAudio : MonoBehaviour
{
    public AudioClip call;
    public AudioSource phoneRinger;
    public AudioClip ring;
    public bool heard;
    
    // Start is called before the first frame update
    void Start()
    {
        phoneRinger.clip = ring;
        phoneRinger.Play();
        heard = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!heard)
        {
            if (Input.GetMouseButtonDown(0))
            {
                phoneRinger.Stop();
                phoneRinger.clip = call;
                phoneRinger.Play();
                heard = true;
            }
        }
        
    }
}
