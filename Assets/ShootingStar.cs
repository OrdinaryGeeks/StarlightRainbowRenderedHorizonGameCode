using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingStar : MonoBehaviour
{

    int player;
    Vector3 direction;
    Vector3 position;
    float speed;
    bool activated;
    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log("Starting");
       // transform.position = LightRegulator.cTransform.position;
      //  transform.forward = LightRegulator.cTransform.forward;
        speed = 5;
        activated = true;

        //   transform.position = Position;
        //  transform.forward = Direction;
        //  speed = Speed;
        activated = false;
    }

    private void Awake()
    {
      //  Debug.Log(transform.position);
       //  direction = transform.position - LightRegulator.cTransform.position ;
    }

    public void setDirection(int Player)
    {

        if (Player == 0)
            direction = transform.position - LightRegulator.cTransform.position;
        if (Player == 1)
            direction = transform.position - Player2Regulator.cTransform.position;

        direction = direction.normalized;


    }
    public void Activate(Vector3 Position, Vector3 Direction, float Speed)
    {

        transform.position = Position;
        transform.forward = Direction;
        speed = Speed;
        activated = true;
    }

    public void DeActivate()
    {
        activated = false;
    }
    // Update is called once per frame
    void Update()
    {

        //  if(activated)
       // Debug.Log(transform.position);
      //  Debug.Log(transform.forward);
        transform.position += direction *8 * Time.deltaTime;


        
    }
}
