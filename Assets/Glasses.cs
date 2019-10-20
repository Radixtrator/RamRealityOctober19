using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses : MonoBehaviour
{
    public float past;
    public GameObject post;
    // Start is called before the first frame update
    void Start()
    {
        past = gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if((gameObject.transform.position.y - past) > .1)
        {
            Debug.Log("picked up");
            post.GetComponent<Recieve>().Clear();
            gameObject.SetActive(false);
        }
    }
}
