using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowStar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mainStar;
    public  GameObject Light1;
    public  GameObject Light2;
    public  GameObject Light3;
    public  GameObject Light4;
    public  GameObject Light5;
    public int oldShoot;
    public List<GameObject> Lights;
    public static List<bool> activated;
    void Start()
    {
        oldShoot = -1;
        Lights = new List<GameObject>();

        Lights.Add(Light1);
        Lights.Add(Light2);
        Lights.Add(Light3);
        Lights.Add(Light4);
        Lights.Add(Light5);

        activated = new List<bool>();



       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = mainStar.transform.position; //- new Vector3(0.0f, 2.0f, 0.0f);


       // if (oldShoot == -1)
        {
     //       Lights[0].GetComponent<Renderer>().material.color = new Color(0, 0, 0);
    //        oldShoot = 0;
//
        }
      //  else if (oldShoot != LightRegulator.shoot)
        {
       //     Lights[oldShoot].GetComponent<Renderer>().material.color = new Color(1, 1, 1);
       //     Lights[LightRegulator.shoot].GetComponent<Renderer>().material.color = new Color(0, 0, 0);
      //      oldShoot = LightRegulator.shoot;
        }

  
    }
}
