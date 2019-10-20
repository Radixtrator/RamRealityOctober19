using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recieve : MonoBehaviour
{
    // Start is called before the first frame update
    public void Clear()
    {
        for(int i = 0; i < gameObject.GetComponents(typeof(Component)).Length; i++)
        {
            Debug.Log(gameObject.GetComponents(typeof(Component))[i]);
            if(i == 6)
            {
                Debug.Log(gameObject.GetComponents(typeof(Component))[i]);
                Destroy(gameObject.GetComponents(typeof(Component))[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
