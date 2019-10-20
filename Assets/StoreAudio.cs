using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreAudio : MonoBehaviour
{
    public bool WheelChair;
    public GameObject Apple;
    public GameObject Banana;
    public GameObject Orange;
    public AudioClip BananaClip;
    public AudioClip OrangeClip;
    public AudioClip AppleClip;
    public AudioClip GreatingClip;
    public AudioSource Robot;
    void Start()
    {
        if(!WheelChair)
        {
            Debug.Log("here");
            Robot.clip = GreatingClip;
            Robot.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (WheelChair && Input.GetKeyDown("space"))
        {
            Robot.clip = GreatingClip;
            Robot.Play();
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
