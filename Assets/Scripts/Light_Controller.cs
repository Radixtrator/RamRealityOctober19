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

    public GameObject player_obj;
    private Transform player;
    private Transform t;

    private bool first_flag = true;

    private int count;

    private void Awake()
    {
        t = this.transform;
        // player = GameObject.FindGameObjectWithTag("MainCamera").transform;
        player = player_obj.transform;
        if (player)
        {
            Debug.Log("aaaaaaaaaaaaaaaaaaa");
            Debug.Log(player.position);
        }
    }

    void Start()
    {
        //lightNumber = 1;
        turnRed();
        //StartCoroutine(LightSwitch());
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position);
        // count += 1;
        // if (player.position.x < -2.5 && player.position.z < 4 && player.position.z > -3 && first_flag)
        // {w

        //     turnGreen();
        //     first_flag = false;
        //     StartCoroutine(LightSwitch());
        // }

        if (Input.GetKeyDown(KeyCode.G))
        {
            turnGreen();
            StartCoroutine(LightSwitch());
        }

    }

    IEnumerator LightSwitch()
    {
        while (true)
        {
            yield return new WaitForSeconds(7);
            turnYellow();
            yield return new WaitForSeconds(2);
            turnRed();
            yield return new WaitForSeconds(15);
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

    public void turnYellow()
    {
        Material[] mats = lights.materials;
        mats[0] = grey;
        mats[2] = yellow;
        mats[3] = grey;
        lights.materials = mats;
    }
    
}
