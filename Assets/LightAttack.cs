using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAttack : MonoBehaviour
{
    public static bool attack;
    public GameObject shootingStar;
    public GameObject FollowLights;
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        attack = false;
    }

    // Update is called once per frame
    void Update()
    {

        /*  if (attack)
          {
              Transform[] transforms = FollowLights.GetComponentsInChildren<Transform>();

              if (LightRegulator.lightPosition == LightRegulator.LightPositions.One)
              {
                  transforms[1].gameObject.GetComponent<Renderer>().enabled = false;
                  GameObject newStar = Instantiate(shootingStar, transforms[1].position, transforms[1].rotation);
                  newStar.GetComponent<Renderer>().material.color = color;
                  LightRegulator.lightPosition = LightRegulator.LightPositions.Two;

              }
              else if (LightRegulator.lightPosition == LightRegulator.LightPositions.Two)
              {
                  transforms[3].gameObject.GetComponent<Renderer>().enabled = false;
                  GameObject newStar = Instantiate(shootingStar, transforms[3], false);
                  newStar.GetComponent<Renderer>().material.color = color;
                  LightRegulator.lightPosition = LightRegulator.LightPositions.Three;

              }
              else if (LightRegulator.lightPosition == LightRegulator.LightPositions.Three)
              {
                  transforms[5].gameObject.GetComponent<Renderer>().enabled = false;
                  GameObject newStar = Instantiate(shootingStar, transforms[5], false);
                  newStar.GetComponent<Renderer>().material.color = color;

                  LightRegulator.lightPosition = LightRegulator.LightPositions.Four;

              }
              else if (LightRegulator.lightPosition == LightRegulator.LightPositions.Four)
              {
                  transforms[7].gameObject.GetComponent<Renderer>().enabled = false;
                  GameObject newStar = Instantiate(shootingStar, transforms[7], false);
                  newStar.GetComponent<Renderer>().material.color = color;
                  LightRegulator.lightPosition = LightRegulator.LightPositions.Five;

              }
              else if (LightRegulator.lightPosition == LightRegulator.LightPositions.Five)
              {
                  transforms[9].gameObject.GetComponent<Renderer>().enabled = false;
                  GameObject newStar = Instantiate(shootingStar, transforms[9], false);
                  newStar.GetComponent<Renderer>().material.color = color;
                  LightRegulator.lightPosition = LightRegulator.LightPositions.One;


              }
              attack = false;
          }*/
        //  Destroy(other.gameObject);

    }
}
