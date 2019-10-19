using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Controller : MonoBehaviour
{
    private int color = 0;
    public MeshRenderer lights;
    public Material red;
    public Material yellow;
    public Material green;
    public Material grey;
        

    // Update is called once per frame
    void Update()
    {
        //Gets trigger input from either controller then changes color of the stop light
        if (Input.GetKeyDown(KeyCode.JoystickButton14))
        {
            ChangeColor();
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton15))
        {
            ChangeColor();
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
    
    public void ChangeColor()
    {
        //Changes color of active stoplight
        if(color < 2)
        {
            color++;
        }
        else
        {
            color = 0;
        }
        if (color == 0)
        {
            Material[] mats = lights.materials;
            mats[0] = green;
            mats[2] = grey;
            mats[3] = grey;
            lights.materials = mats;
        }
        else if (color == 1)
        {
            Material[] mats = lights.materials;
            mats[0] = grey;
            mats[2] = yellow;
            mats[3] = grey;
            lights.materials = mats;
        }
        else if (color == 2)
        {
            Material[] mats = lights.materials;
            mats[0] = grey;
            mats[2] = grey;
            mats[3] = red;
            lights.materials = mats;
        }
    }
}
