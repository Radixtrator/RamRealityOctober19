using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class MoveForwBack : MonoBehaviour
{
    public SteamVR_Action_Boolean MoveF;
    public SteamVR_Action_Boolean MoveB;
    public Hand hand;
    public GameObject player;
    public IEnumerator coroutine;
    public float speed;
    public SteamVR_Input_Sources handType;
    public bool isMoving = false;

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
            Debug.Log("Is Moving");
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
        Vector3 velocity = new Vector3(this.GetComponent<Transform>().forward.x, 0, this.GetComponent<Transform>().forward.z) * Time.deltaTime*speed;
        player.transform.Translate(velocity, Space.World);
        // player.position += velocity;
        Debug.Log(this.GetComponent<Transform>().forward);
        Debug.Log("Forward");
        yield return new WaitForSeconds(0.0f);
        //yield return null;
    }
    private IEnumerator DoMoveB()
    {
        Debug.Log("Backward");
        yield return null;
    }
}