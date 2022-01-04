using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollision : MonoBehaviour
{
    // Start is called before the first frame update
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
            for(int i = 0; i<LightRegulator.ranks.Count; i++)
            for (int j = 0; j < LightRegulator.ranks[i].occupied.Count; j++)
            {

                if (LightRegulator.ranks[i].occupied[j] == false)
                {
                        rankIndex = i;
                    occupiedIndex = j;
                    LightRegulator.ranks[i].occupied[j] = true;
                    break;
                }

            }

            if(occupiedIndex == -1  && rankIndex != 2)
            {
                LightRegulator.ranks.Add(new LightRegulator.Rank(5));
                LightRegulator.ranks[LightRegulator.ranks.Count - 1].occupied[0] = true;

                transforms[6].gameObject.GetComponent<Renderer>().material.color += color;
                transforms[6].gameObject.GetComponent<Light>().color += color;


            }
            
            else if(rankIndex == 0) {

               
                LightRegulator.ranks[rankIndex].occupied[occupiedIndex] = true;
                transforms[occupiedIndex + 1].gameObject.GetComponent<Renderer>().enabled = false;
                GameObject newStar = Instantiate(star, transforms[0], false);
                newStar.transform.position = transforms[occupiedIndex + 1].position;
                newStar.transform.rotation = transforms[occupiedIndex + 1].rotation;
                newStar.tag = "Player1Star";
                newStar.GetComponent<Renderer>().material.color = color;
                newStar.GetComponent<Light>().color = color;
                //    newStar.GetComponent
                newStar.GetComponent<Renderer>().enabled = false;

            }
            else
            {
                LightRegulator.ranks[rankIndex].occupied[occupiedIndex] = true;

              //  Debug.Log(rankIndex + " " + occupiedIndex + " " + transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color);
                transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color += color;
                //  Debug.Log(transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color + " " + occupiedIndex);

                
                   transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color = new Color(transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color.r, transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color.g, transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color.b, 255);
                transforms[occupiedIndex + 6].gameObject.GetComponent<Light>().color = transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color;
                // if (occupiedIndex == 4)
                //   transforms[occupiedIndex + 6].gameObject.GetComponent<Renderer>().material.color = new Color(255, 255, 255, 255);

            }
           /* if (occupiedIndex != -1)
            {
                LightRegulator.occupied[nextIndex] = true;
                transforms[nextIndex + 1].gameObject.GetComponent<Renderer>().enabled = false;
                GameObject newStar = Instantiate(star, transforms[0], false);
                newStar.transform.position = transforms[nextIndex + 1].position;
                newStar.transform.rotation = transforms[nextIndex + 1].rotation;
                newStar.tag = "Player1Star";
                newStar.GetComponent<Renderer>().material.color = color;
               // LightRegulator.lightPosition = LightRegulator.LightPositions.Two;


            }*/
           /* if (LightRegulator.lightPosition == LightRegulator.LightPositions.One)
            {
                transforms[1].gameObject.GetComponent<Renderer>().enabled = false;

               // if()
                GameObject newStar = Instantiate(star, transforms[0], false);
                newStar.transform.position = transforms[1].position;
                newStar.transform.rotation = transforms[1].rotation;
                newStar.tag = "Player1Star";
                newStar.GetComponent<Renderer>().material.color = color;
                LightRegulator.lightPosition = LightRegulator.LightPositions.Two;

            }
            else if (LightRegulator.lightPosition == LightRegulator.LightPositions.Two)
            {
                   transforms[2].gameObject.GetComponent<Renderer>().enabled = false;
                // GameObject newStar = Instantiate(star, transforms[2].position, transforms[2].rotation);
           
                GameObject newStar = Instantiate(star, transforms[0], false);
                newStar.transform.position = transforms[2].position;
                newStar.transform.rotation = transforms[2].rotation;
                newStar.tag = "Player1Star";

                newStar.GetComponent<Renderer>().material.color = color;
                LightRegulator.lightPosition = LightRegulator.LightPositions.Three;

            }
            else if (LightRegulator.lightPosition == LightRegulator.LightPositions.Three)
            {
                  transforms[3].gameObject.GetComponent<Renderer>().enabled = false;
                //    GameObject newStar = Instantiate(star, transforms[3].position, transforms[3].rotation);
                GameObject newStar = Instantiate(star, transforms[0], false);
                newStar.transform.position = transforms[3].position;
                newStar.transform.rotation = transforms[3].rotation;
                newStar.tag = "Player1Star";
                newStar.GetComponent<Renderer>().material.color = color;
                newStar.tag = "Player1Star";
                LightRegulator.lightPosition = LightRegulator.LightPositions.Four;

            }
            else if (LightRegulator.lightPosition == LightRegulator.LightPositions.Four)
            {
                transforms[4].gameObject.GetComponent<Renderer>().enabled = false;
             //   GameObject newStar = Instantiate(star, transforms[4].position, transforms[4].rotation);
                GameObject newStar = Instantiate(star, transforms[0], false);
                newStar.transform.position = transforms[4].position;
                newStar.transform.rotation = transforms[4].rotation;
                newStar.GetComponent<Renderer>().material.color = color;
                newStar.tag = "Player1Star";
                LightRegulator.lightPosition = LightRegulator.LightPositions.Five;

            }
            else if (LightRegulator.lightPosition == LightRegulator.LightPositions.Five)

            {
                transforms[5].gameObject.GetComponent<Renderer>().enabled = false;
               // GameObject newStar = Instantiate(star, transforms[5].position, transforms[5].rotation);
                GameObject newStar = Instantiate(star, transforms[0], false);
                newStar.transform.position = transforms[5].position;
                newStar.transform.rotation = transforms[5].rotation;
                newStar.GetComponent<Renderer>().material.color = color;
                newStar.tag = "Player1Star";
                LightRegulator.lightPosition = LightRegulator.LightPositions.One;

            }
            */
            Destroy(other.gameObject);





            // newStar.transform.parent = transform;

        }





    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
