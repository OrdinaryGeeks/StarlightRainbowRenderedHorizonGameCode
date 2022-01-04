using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStar : MonoBehaviour
{
    // Start is called before the first frame update

    public static Quaternion Rotation;
    void Start()
    {
        Rotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.AngleAxis(20 * Time.deltaTime, Vector3.up);

        Rotation = transform.rotation;
    }
}
