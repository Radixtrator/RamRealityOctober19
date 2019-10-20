using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class policCar1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pc1;
    public GameObject pc2;

    public GameObject redLight;
    public GameObject blueLight;

    public GameObject sound;

    bool first_done = false;
    bool second_done = false;

    bool all_done = false;

    Coroutine co;
    Coroutine co1;

    void Start()
    {
      pc2.SetActive(false);
      pc1.SetActive(false);
      redLight.SetActive(false);
      blueLight.SetActive(false);
      sound.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C) && !first_done && !all_done){
          pc1.SetActive(true);
          sound.SetActive(true);
          first_done = true;
          co = StartCoroutine(Siren());
        }
        if(Input.GetKeyDown(KeyCode.V) && first_done && !second_done && !all_done){
          pc2.SetActive(true);
          pc1.SetActive(false);
          second_done = true;
        }

        if(first_done && !second_done && !all_done){
          // redLight.SetActive(true);
          // blueLight.SetActive(true);

          redLight.transform.position = new Vector3(pc1.transform.position.x - (float)0.3, pc1.transform.position.y + (float)1.58, pc1.transform.position.z - (float)0.3);
          blueLight.transform.position = new Vector3(pc1.transform.position.x + (float)0.3, pc1.transform.position.y + (float)1.58, pc1.transform.position.z - (float)0.3);
          sound.transform.position = new Vector3(pc1.transform.position.x + (float)0.3, pc1.transform.position.y + (float)1.58, pc1.transform.position.z - (float)0.3);

        }

        if(second_done && !all_done){
          redLight.transform.position = new Vector3(pc2.transform.position.x - (float)0.3, pc2.transform.position.y + (float)1.58, pc2.transform.position.z - (float)0.3);
          blueLight.transform.position = new Vector3(pc2.transform.position.x + (float)0.3, pc2.transform.position.y + (float)1.58, pc2.transform.position.z - (float)0.3);
          sound.transform.position = new Vector3(pc2.transform.position.x + (float)0.3, pc2.transform.position.y + (float)1.58, pc2.transform.position.z - (float)0.3);

          if(pc2.transform.position.x >= 44 && !all_done){
            StopCoroutine(co);
            StartCoroutine(Siren2());
            sound.SetActive(false);
          }
        }

        if(all_done){
          StopCoroutine(co1);
          redLight.SetActive(false);
          blueLight.SetActive(false);
          pc2.SetActive(false);
        }



        //if(first_done){
        //  StartCoroutine(Siren());
        //}

    }

    IEnumerator Siren(){
      while(true){
        redLight.SetActive(true);
        blueLight.SetActive(false);
        yield return new WaitForSeconds(1);
        blueLight.SetActive(true);
        redLight.SetActive(false);
        yield return new WaitForSeconds(1);
      }
    }

    IEnumerator Siren2(){
      int count = 0;
      while(count < 3){
        redLight.SetActive(true);
        blueLight.SetActive(false);
        yield return new WaitForSeconds(1);
        blueLight.SetActive(true);
        redLight.SetActive(false);
        yield return new WaitForSeconds(1);
        count += 1;
      }
      all_done = true;
      // pc2.SetActive(false);
      // redLight.SetActive(false);
      // blueLight.SetActive(false);
    }


}
