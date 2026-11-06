using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TumourPulsing : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float degreesPerSecond = 2.0f;

    public GameObject tumour;
    public Vector3 ScaleChange;
   
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = new Vector3(Mathf.Sin(Time.time), Mathf.Sin(Time.time), Mathf.Sin(Time.time));

        transform.localScale = vec;
    }
}
