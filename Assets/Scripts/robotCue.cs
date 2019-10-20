using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotCue : MonoBehaviour
{
    public AudioClip robot_talking;
    public AudioSource robot;
    public Vector3 past;

    // Start is called before the first frame update
    void Start()
    {
        past = gameObject.transform.position;
        robot.clip = robot_talking;

    }

    // Update is called once per frame
    void Update()
    {
            if (Vector3.Distance(past, gameObject.transform.position) > .1)
            {
                Debug.Log("here");
                robot.Play();
            }
            past = gameObject.transform.position;
     }

    }
