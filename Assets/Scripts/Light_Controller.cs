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
    public int timeGreen;
    public GameObject total;

    // public GameObject player_obj;
    // private Transform player;
    private Transform t;

    public GameObject textBoard;
    private Renderer board_rend;

    private bool first_flag = true;
    private int timeLeft = 10;

    public TextMesh countdown;
    private Coroutine co;
    private float StartTime;
    bool counting = false;

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
        //turnRed();
        Material[] mats = lights.materials;
        mats[0] = grey;
        mats[2] = grey;
        mats[3] = red;
        lights.materials = mats;
        board_rend.sharedMaterial = red;
        //StartCoroutine(LightSwitch());
        //StartCoroutine(StartCountdown());

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
            StartTime = Time.time;
            turnGreen();
            StartCoroutine(LightSwitch());
            counting = true;
        }
        if (counting)
        {
            int val = ((int)(6.0f - (Time.time - StartTime)));
            countdown.text = val.ToString();
            if(val == 0)
            {
                counting = false;
            }
        }
    
 

    }

    IEnumerator LightSwitch()
    {
        while (true)
        {
            yield return new WaitForSeconds(6);
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

    IEnumerator StartCountdown(int countdownValue)
    {
        int currCountdownValue;
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
        total.SetActive(true) ;
        Material[] mats = lights.materials;
        mats[0] = green;
        mats[2] = grey;
        mats[3] = grey;
        lights.materials = mats;
        board_rend.sharedMaterial = green;
        StartTime = Time.time;
        counting = true;

        //textBoard.GetComponent<Text>();
        //StopCoroutine(co);
        //co = StartCoroutine(StartCountdown(6));
    }

    public void turnRed()
    {
        total.SetActive(false);
        Material[] mats = lights.materials;
        mats[0] = grey;
        mats[2] = grey;
        mats[3] = red;
        lights.materials = mats;
        board_rend.sharedMaterial = red;

        //StopCoroutine(co);
        //co = StartCoroutine(StartCountdown(15));
    }

    public void turnYellow()
    {
        total.SetActive(false);
        Material[] mats = lights.materials;
        mats[0] = grey;
        mats[2] = yellow;
        mats[3] = grey;
        lights.materials = mats;
        board_rend.sharedMaterial = yellow;
        //StopCoroutine(co);
        //co = StartCoroutine(StartCountdown(2));
    }
    
}
