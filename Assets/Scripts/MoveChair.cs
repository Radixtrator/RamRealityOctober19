using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;
using System;

public class MoveChair : MonoBehaviour
{
    public SteamVR_Action_Boolean MoveF;
    public SteamVR_Action_Boolean MoveB;
    public Hand hand;
    public GameObject player;
    public GameObject chair;
    public IEnumerator coroutine;
    public float speed;
    public SteamVR_Input_Sources handType;
    public bool isMoving = false;
    public bool onRamp = false;

    private void OnEnable()
    {
        if (hand == null)
        {
            hand = this.GetComponent<Hand>();
        }
        if (MoveF == null)
        {
            Debug.Log("NO move action assigned");
            return;
        }
        if (MoveB == null)
        {
            Debug.Log("NO move action assigned");
            return;
        }
        // coroutine = DoMoveF();
        // MoveF.AddOnChangeListener(OnMoveChange, hand.handType);
        // MoveB.AddOnChangeListener(OnMoveChange, hand.handType);
    }
    public void getMoving() {
        if (MoveF.GetStateDown(hand.handType))
        {
            isMoving = true;
        }
        else if (MoveF.GetStateUp(hand.handType))
        {
            isMoving = false;
        }
        else {
            
        }
    }
    void Update() {
        getMoving();
        if (isMoving)
        {
            
            Move(true);
        }
        //else {
          //StopCoroutine(coroutine);
        //}


    }
    /* private void OnDisable()
    {
        if (MoveF != null)
        {
            MoveF.RemoveOnChangeListener(OnMoveChange, hand.handType);
        }
        if (MoveB != null)
        {
            MoveB.RemoveOnChangeListener(OnMoveChange, hand.handType);
        }
    }
    private void OnMoveChange(SteamVR_Action_Boolean actionIn, SteamVR_Input_Sources inputSource, bool newValue)
    {
        if (newValue)
        {
            Move(actionIn == MoveF);

        }
      
        
    } */
   


    public void Move(bool forward)
    {
        if (forward == true)
            StartCoroutine(DoMoveF());
        else {
            StartCoroutine(DoMoveB());
        }
    }
    private  IEnumerator DoMoveF()
    {
        if (!onRamp)
        {
            Debug.Log("under");
            Vector3 velocity = new Vector3(this.GetComponent<Transform>().forward.x, 0, this.GetComponent<Transform>().forward.z) * Time.deltaTime * speed;
            player.transform.Translate(velocity, Space.World);
            chair.transform.Translate(velocity, Space.World);
        }
        else
        {
            Debug.Log("Over");
            Vector3 velocity = new Vector3(this.GetComponent<Transform>().forward.x, (float)(this.GetComponent<Transform>().forward.z)*.1f, this.GetComponent<Transform>().forward.z) * Time.deltaTime * speed;
            player.transform.Translate(velocity, Space.World);
            chair.transform.Translate(velocity, Space.World);
        }
        // player.position += velocity;
        yield return new WaitForSeconds(0.0f);
    }
    private IEnumerator DoMoveB()
    {
        Vector3 velocity = new Vector3(this.GetComponent<Transform>().forward.x, 0, this.GetComponent<Transform>().forward.z) * Time.deltaTime * -speed;
 
        player.transform.Translate(velocity, Space.World);
        // player.position += velocity;
        yield return new WaitForSeconds(0.0f);
    }
}