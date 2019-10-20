using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotCue : MonoBehaviour
{
    public AudioClip robot_talking;
    public AudioSource robot;
    public GameObject Banana;
    public Vector3 BananaPast;
    public GameObject Apple;
    public Vector3 ApplePast;
    public GameObject Orange;
    public Vector3 OrangePast;
    // Start is called before the first frame update
    void Start()
    {
        ApplePast = Apple.transform.position;
        OrangePast = Orange.transform.position;
        BananaPast = Banana.transform.position;
        robot.clip = robot_talking;
    }

    // Update is called once per frame
    void Update()
    {
            if ((Vector3.Distance(ApplePast, Apple.transform.position) > .2) || (Vector3.Distance(OrangePast, Orange.transform.position) > .2) || (Vector3.Distance(BananaPast, Banana.transform.position) > .2))
            {
                Debug.Log("here");
                robot.Play();
            }
            ApplePast = Apple.transform.position;
            BananaPast = Banana.transform.position;
            OrangePast = Orange.transform.position;
    }

    }
