using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2LightCollision : MonoBehaviour
{
    // Start is called before the first frame update
    // public GameObject star;
    //  public GameObject FollowLights;

    public GameObject star;
    public GameObject FollowLights;
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //  Debug.Log("Triggered");
        //other.gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
        //other.
        //transform.parent = this.gameObject.transform;


        if (other.gameObject.tag == "Star")
        {
            Color color = other.gameObject.GetComponent<Renderer>().material.color;

            // Debug.Log(other.gameObject.tag);
            //  Destroy(other.gameObject);

            //    Transform starTransform = transform;
            //  starTransform.position += new Vector3(0.0f, 0.0f, 3.0f);


            //                GameObject newStar = Instantiate(star, starTransform, true);


            //         newStar.GetComponent<Renderer>().material.color = color;

            Transform[] transforms = FollowLights.GetComponentsInChildren<Transform>();


            /*This was originally Instantiate(star,transforms[1], false) transforms[3] transforms[5] transforms[7] transforms[9] modifying it
             * so that the stars dont add to the position but I am thjinking this isnt' what I want to do
             *Instantiate(star, transforms[3], false); old way that binds it to the current followlights new way is the position and rotation
             * Second way was to set it to Instantiate(star, transforms[1].position, transforms[1].rotation)
             */

            int rankIndex = -1;
            int occupiedIndex = -1;
            for (int i = 0; i < Player2Regulator.ranks.Count; i++)
                for (int j = 0; j < Player2Regulator.ranks[i].occupied.Count; j++)
                {

                    if (Player2Regulator.ranks[i].occupied[j] == false)
                    {
                        rankIndex = i;
                        occupiedIndex = j;
                        Player2Regulator.ranks[i].occupied[j] = true;
                        break;
                    }

                }

            if (occupiedIndex == -1 && rankIndex != 2)
            {
                Player2Regulator.ranks.Add(new Player2Regulator.Rank(5));
                Player2Regulator.ranks[Player2Regulator.ranks.Count - 1].occupied[0] = true;

                transforms[6].gameObject.GetComponent<Renderer>().material.color += color;
                transforms[6].gameObject.GetComponent<Light>().color += color;
                

            }

            else if (rankIndex == 0)
            {


                Player2Regulator.ranks[rankIndex].occupied[occupiedIndex] = true;
                transforms[occupiedIndex + 1].gameObject.GetComponent<Renderer>().enabled = false;
                GameObject newStar = Instantiate(star, transforms[0], false);
                newStar.transform.position = transforms[occupiedIndex + 1].position;
                newStar.transform.rotation = transforms[occupiedIndex + 1].rotation;
                newStar.tag = "Player2Star";
                newStar.GetComponent<Renderer>().material.color = color;
                newStar.GetComponent<Light>().color = color;
                newStar.GetComponent<Renderer>().enabled = false;


            }
            else
            {
                Player2Regulator.ranks[rankIndex].occupied[occupiedIndex] = true;

                //  Debug.Log(rankIndex + " " + occupiedIndex + " " + transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color);
                transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color += color;
                //  Debug.Log(transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color + " " + occupiedIndex);


                transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color = new Color(transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color.r, transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color.g, transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color.b, 255);
                transforms[occupiedIndex + 6].gameObject.GetComponent<Light>().color = transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color;
                // if (occupiedIndex == 4)
                //   transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color = new Color(255, 255, 255, 255);

            }

            Destroy(other.gameObject);
        }

            if (other.gameObject.tag == "Player1Shooter")
        {
           // Debug.Log("Hello P2LC OTE");
            Destroy(other.gameObject);

            Color color = other.gameObject.GetComponent<Renderer>().material.color;

            // Debug.Log(other.gameObject.tag);
            //  Destroy(other.gameObject);

            //    Transform starTransform = transform;
            //  starTransform.position += new Vector3(0.0f, 0.0f, 3.0f);


            //                GameObject newStar = Instantiate(star, starTransform, true);


            //         newStar.GetComponent<Renderer>().material.color = color;

            





            // newStar.transform.parent = transform;

        }





    }
    // Update is called once per frame
    void Update()
    {
       // Debug.Log("P2lC Update");
    }
}
