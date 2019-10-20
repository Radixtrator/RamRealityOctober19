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
        Robot.clip = AppleClip;
        Robot.Play();
    }
    public void PlayOrange()
    {
        Robot.clip = OrangeClip;
        Robot.Play();
    }
    public void PlayBanana()
    {
        Robot.clip = BananaClip;
        Robot.Play();
    }
}
