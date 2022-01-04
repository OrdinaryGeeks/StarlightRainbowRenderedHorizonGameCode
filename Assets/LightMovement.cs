using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMovement : MonoBehaviour
{
    // Start is called before the first frame update

    Ray camRay;
    LayerMask floor;
    Vector3 targetDestination;
    float distanceToDestination;
    float oldDistanceToDestination;
    bool isMoving;
    Transform fakeTransform;
    public static Quaternion Rotation;
    public GameObject planet;
    enum MovingStates { Open, Aim, Move}
    MovingStates movingState;
    void Start()
    {
        Rotation = transform.rotation;
        floor = LayerMask.GetMask("Space");
        isMoving = false;
        movingState = MovingStates.Open;

        Camera.main.GetComponent<CameraFollow>().mode = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.GetComponent<CameraFollow>().mode == 0)
        {
            if (Vector3.Distance(planet.transform.position, transform.position) < 15)
                Camera.main.GetComponent<CameraFollow>().mode = 1;
            //   if(movingState == MovingStates.Aim)
            {

                //     transform.LookAt(targetDestination);
                //      movingState = MovingStates.Move;
            }
            if (movingState == MovingStates.Move)
            {
                if (!atDestination())
                {
                    //   Debug.Log("Moving not at destination");
                    transform.position += transform.forward * LightRegulator.speed * Time.deltaTime;

                }

            }


            if (Input.GetMouseButton(0))
            {

                camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit floorHit;
                if (Physics.Raycast(camRay, out floorHit, 10000, floor))
                {
                    movingState = MovingStates.Move;

                    targetDestination = floorHit.point + new Vector3(0.0f, 2.0f, 0.0f);
                    transform.LookAt(targetDestination);
                    oldDistanceToDestination = Vector3.Distance(targetDestination, transform.position);
                    distanceToDestination = oldDistanceToDestination;
                    //   Debug.Log(targetDestination);
                }
            }

            if (Input.GetMouseButtonDown(1))
            {
                camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit floorHit;

                if (Physics.Raycast(camRay, out floorHit, 10000, floor))
                {
                    //  Debug.Log(transform.rotation.eulerAngles);
                    transform.LookAt(floorHit.point + new Vector3(0.0f, 2.0f, 0.0f));
                    //  Debug.Log(transform.rotation.eulerAngles);
                    //  Debug.Log("Break");
                    Rotation = transform.rotation;

                }

            }
        }
    }

    bool atDestination()
    {
        //        Vector3 oldDistanceTodestination;
        oldDistanceToDestination = distanceToDestination;
        distanceToDestination = Vector3.Distance(transform.position, targetDestination);
      //  if (Vector3.Distance(transform.position, targetDestination) < 1.0f)
         //   Debug.Log("Distancer");
        //if (oldDistanceToDestination < distanceToDestination + 0.10f)
        //    Debug.Log("Old");
        if (Vector3.Distance(transform.position, targetDestination) < 1.0f)                 //|| oldDistanceToDestination < distanceToDestination)
        {
            movingState = MovingStates.Open;
            oldDistanceToDestination = 0;
            return true;
        }
        return false;
    }
}
