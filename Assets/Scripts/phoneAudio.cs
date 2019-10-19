using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phoneAudio : MonoBehaviour
{
    public AudioClip call;
    public AudioSource phoneRinger;
    public AudioClip ring;
    public bool heard;
    public Vector3 past;
    
    // Start is called before the first frame update
    void Start()
    {
        past = gameObject.transform.position;
        phoneRinger.clip = ring;
        phoneRinger.Play();
        heard = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!heard)
        {
            if (Vector3.Distance(past, gameObject.transform.position) > .1)
            {
                Debug.Log("here");
                phoneRinger.Stop();
                phoneRinger.clip = call;
                phoneRinger.Play();
                heard = true;
            }
            past = gameObject.transform.position;
        }
        
    }
}
