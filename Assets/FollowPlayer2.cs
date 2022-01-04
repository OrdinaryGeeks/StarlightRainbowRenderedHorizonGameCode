using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player2.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
      //  Debug.Log("In On trigger");
        if(other.gameObject.tag == "Star")
        {
          //  Debug.Log("Hit Star");
            player2.GetComponent<Player2Regulator>().growTarget = other.transform.position;
            player2.GetComponent<Player2Regulator>().switchToGrowState = true;
            if(player2.GetComponent<Player2Regulator>().shotsAvailable <Player2Regulator.ranks[0].occupied.Count)
            player2.GetComponent<Player2Regulator>().shotsAvailable++;


        }
    }
}
