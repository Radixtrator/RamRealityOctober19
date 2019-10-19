using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
[RequireComponent(typeof(SteamVR_TrackedObject))]

public class Movment : MonoBehaviour
{
    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device Device;
    // Start is called before the first frame update
    void Awake()
    {
      trackedObj = GetComponent<SteamVR_TrackedObject>();
    }
    void Start()
    {

    }

    void FixedUpdate()
    {
        Device = SteamVR_Controller.Input((int)trackedObj.index);
    }
    // Update is called once per frame
    void Update()
    {
      void Update()
      {
          if (Device.GetPress(SteamVR_Controller.ButtonMask.Touchpad))
          {
              Vector2 touchpad = (Device.GetAxis(Valve.VR.EVRButtonId.k_EButton_Axis0));
              print("Pressing Touchpad");

              if (touchpad.y > 0.7f)
              {
                  print("Moving Up");
              }

              else if (touchpad.y < -0.7f)
              {
                  print("Moving Down");
              }

              if (touchpad.x > 0.7f)
              {
                  print("Moving Right");

              }

              else if (touchpad.x < -0.7f)
              {
                  print("Moving left");
              }

          }
      }
    }
}
