using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Light_Controller : MonoBehaviour
{
    private int color = 0;
    public MeshRenderer lights;
    public Material red;
    public Material yellow;
    public Material green;
    public Material grey;

    // public GameObject player_obj;
    // private Transform player;
    private Transform t;

    public GameObject textBoard;
    private Renderer board_rend;

    private bool first_flag = true;
    private int timeLeft = 10;

    public TextMesh countdown;

    private void Awake()
    {
        t = this.transform;
        // player = GameObject.FindGameObjectWithTag("MainCamera").transform;
        // player = player_obj.transform;
        // if (player)
        // {
        //    Debug.Log("aaaaaaaaaaaaaaaaaaa");
        //    Debug.Log(player.position);
        //}
        //counter = 0;
        board_rend = textBoard.GetComponent<Renderer>();
        board_rend.enabled = true;
       // countdown = textBoard.GetComponent<TextMesh>();
        Time.timeScale = 1;
    }

    void Start()
    {
        //lightNumber = 1;
        turnRed();
        //StartCoroutine(LightSwitch());
        StartCoroutine(StartCountdown());

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position);
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

        countdown.text = timeLeft.ToString();

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
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }

    IEnumerator StartCountdown(int countdownValue = 10)
    {
        int currCountdownValue = timeLeft;
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            Debug.Log("Countdown: " + currCountdownValue);
            yield return new WaitForSeconds(1);
            currCountdownValue--;
            timeLeft = currCountdownValue;

        }
    }

    public void turnGreen()
    {
        Material[] mats = lights.materials;
        mats[0] = green;
        mats[2] = grey;
        mats[3] = grey;
        lights.materials = mats;
        board_rend.sharedMaterial = green;
        //textBoard.GetComponent<Text>();
    }

    public void turnRed()
    {
        Material[] mats = lights.materials;
        mats[0] = grey;
        mats[2] = grey;
        mats[3] = red;
        lights.materials = mats;
        board_rend.sharedMaterial = red;
    }

    public void turnYellow()
    {
        Material[] mats = lights.materials;
        mats[0] = grey;
        mats[2] = yellow;
        mats[3] = grey;
        lights.materials = mats;
        board_rend.sharedMaterial = yellow;
    }
    
}
