using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightChange : MonoBehaviour
{
    //public GameObject lightOne;
    public bool lightOn = false;
    //public int lightNumber;

    public MeshRenderer lights;
    public Material red;
    public Material yellow;
    public Material green;
    public Material grey;
    void Start()
    {
        //lightNumber = 1;
        turnRed();
        // StartCoroutine(LightSwitch());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("clision!");
            //lightTwo.SetActive(true);
            //lightOne.SetActive(false);
            turnGreen();
        }
    }

    public void turnGreen()
    {
        Material[] mats = lights.materials;
        mats[0] = green;
        mats[2] = grey;
        mats[3] = grey;
        lights.materials = mats;
    }

    public void turnRed()
    {
        Material[] mats = lights.materials;
        mats[0] = grey;
        mats[2] = grey;
        mats[3] = red;
        lights.materials = mats;
    }

    /*  IEnumerator LightSwitch()
      {
          yield return new WaitForSeconds(5);
          lightTwo.SetActive(true);
          lightOne.SetActive(false);
          lightOn = true;
          ligthNumber = 2;

      }*/

}
