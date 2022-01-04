using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeRotation : MonoBehaviour
{
    // Start is called before the first frame update
    Quaternion rotation;
    private void Awake()
    {
        rotation = transform.rotation;
    }
    void Start()
    {
        rotation = transform.rotation;
    }
    private void LateUpdate()
    {
        // Debug.Log("In late update");

      //  Debug.Log(transform.rotation + " " + rotation);
        transform.rotation = rotation;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
