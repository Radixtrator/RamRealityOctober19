using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreCounter : MonoBehaviour
{
    public int items = 0;
    public GameObject AudioManager;
    private StoreAudio Sa;
    // Start is called before the first frame update
    void Start()
    {
        Sa = AudioManager.GetComponent<StoreAudio>();
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
            Destroy(collision.gameObject);
            Debug.Log(collision);
        }
        if(collision.gameObject.layer == 8)
        {
            Sa.PlayApple();
        }
        if (collision.gameObject.layer == 9)
        {
            Sa.PlayOrange();
        }
        if (collision.gameObject.layer == 10)
        {
            Sa.PlayBanana();
        }

    }
}
