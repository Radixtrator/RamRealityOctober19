using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject camera;
    public GameObject player;
    public float offset;
    public float offset2;
    public Vector3 tripleOffset;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            Debug.Log("here");
            tripleOffset = new Vector3(player.transform.position.x - offset2, gameObject.transform.position.y, player.transform.position.z - offset) - new Vector3(camera.transform.position.x - offset, 0f, camera.transform.position.z);
            gameObject.transform.position = new Vector3(player.transform.position.x - offset2, gameObject.transform.position.y, player.transform.position.z - offset) + tripleOffset;
        }
        //gameObject.transform.position = tripleOffset;
        // gameObject.transform.position = new Vector3(player.transform.position.x, gameObject.transform.position.y, player.transform.position.y);
        gameObject.transform.rotation = (player.transform.rotation);
    }
}
