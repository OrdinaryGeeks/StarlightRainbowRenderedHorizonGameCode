using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Color color = Random.ColorHSV(0, 1, 1, 1, 1, 1);
        // color.a = 255.0f;

        
        int intensity = Random.Range(0, 256);

        GetComponent<Renderer>().material.color = color;

        GetComponent<Light>().color = color;
     //  Debug.Log(color);
        // Debug.Log(color);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
