using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreCounter : MonoBehaviour
{
    public int items = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (items == 3)
            Debug.Log("GJ You win");
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "store")
        {
            items++;
        }
        Debug.Log(collision);
    }
}
