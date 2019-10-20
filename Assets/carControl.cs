using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carControl : MonoBehaviour
{
    public List<GameObject> cars = new List<GameObject>();
    //Random random = new Random();
    // Start is called before the first frame update
    private void Awake()
    {
        foreach (var car in cars)
        {
            car.SetActive(false);
        }
    }
    void Start()
    {
        StartCoroutine(carGenerator());
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    IEnumerator carGenerator()
    {
        var random = new Random();
        while (true)
        {
            int index = Random.Range(0, cars.Count);
            GameObject car = cars[index];
            if(car.transform.position.z < -100)
            {
                cars[index].SetActive(false);
                cars[index].SetActive(true);
            } 
            
            yield return new WaitForSeconds(1);
        }
    }
}
