using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTransitionManager : MonoBehaviour
{
    public BoxCollider door;
    public string sceneName;
    public string tag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("here");
        if (other.gameObject.tag == tag)
        {
            Debug.Log("here");
            SceneManager.LoadScene(sceneName);
        }
    }
    void Update()
    {
    }
}
