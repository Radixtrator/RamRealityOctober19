using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreAudio : MonoBehaviour
{
    public AudioClip BananaClip;
    public AudioClip OrangeClip;
    public AudioClip AppleClip;
    public AudioClip GreatingClip;
    public AudioSource Robot;
    public AudioClip finished;
    public int counter;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Robot.clip = GreatingClip;
            Robot.Play();
            Debug.Log("Here");  
        }
    }
    public void PlayApple()
    {
        if (counter != 2)
        {
            Robot.clip = AppleClip;
            Robot.Play();
            counter++;
        }
    }

    public void PlayFinished()
    { if (counter != 2)
        {
            Robot.clip = finished;
            Robot.Play();
            counter++;
        }
    }
    public void PlayOrange()
    {
        if (counter != 2)
        {
            Robot.clip = OrangeClip;
            Robot.Play();
        }
    }
    public void PlayBanana()
    {
        if (counter != 2)
        {
            counter++;
            Robot.clip = BananaClip;
            Robot.Play();
        }
    }
}
