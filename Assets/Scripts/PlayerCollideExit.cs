﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollideExit : MonoBehaviour
    
{
    public GameObject hand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "ramp")
        {
            hand.GetComponent<MoveChair>().onRamp = false;
            Debug.Log("Hit Ramp" + collision);
        }
        Debug.Log(collision);
    }
}
