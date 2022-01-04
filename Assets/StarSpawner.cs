using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    float count;
    float elapsedTime;
    public GameObject newStar;
    bool oneStar;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if(elapsedTime > 4.0f )
        {
            elapsedTime = 0.0f;
           

            float x = Random.Range(-14, 14);
            float z = Random.Range(-14, 14);

            Instantiate(newStar, new Vector3(x, 2.0f, z), Quaternion.identity);

        }
    }
}
