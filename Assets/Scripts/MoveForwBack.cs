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
    public Transform player;
    public IEnumerator coroutine;
    public float speed;
    // Start is called before the first frame update
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
    void Update() {
        if (SteamVR_Input.GetState("default", "MoveF", hand.handType))
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
        Vector3 velocity = new Vector3(this.GetComponent<Transform>().forward.x, 0, this.GetComponent<Transform>().forward.z) * Time.DeltaTime*speed;
        player.position += 
        Debug.Log(this.GetComponent<Transform>().forward);
        Debug.Log("Forward");
        yield return null;
    }
    private IEnumerator DoMoveB()
    {
        Debug.Log("Backward");
        yield return null;
    }
}