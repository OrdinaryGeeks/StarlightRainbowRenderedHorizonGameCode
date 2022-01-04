using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    // Start is called before the first frame update

    public bool blowUp;
    public GameObject bombExplosion;
    float elapsedTime;
    public Vector3 direction;
    void Start()
    {
        blowUp = false;
        elapsedTime = 0;
    }

    public void setDirection(int Player)
    {
        if (Player == 0)
            direction = transform.position - LightRegulator.cTransform.position;
        if (Player == 1)
            direction = transform.position - Player2Regulator.cTransform.position;

        direction = direction.normalized;



    }
    // Update is called once per frame
    void Update()
    {
        transform.position += direction * 4 * Time.deltaTime;
        Transform[] transforms = gameObject.GetComponentsInChildren<Transform>();
        if (blowUp)
        {
            Debug.Log(transforms[1].gameObject.name);
            Debug.Log(blowUp + " is blowUp ");
            bombExplosion.SetActive(true);
            bombExplosion.GetComponent<ParticleSystem>().Play(true);
           

        }
    }

    public void setBlowUp()
    {

        blowUp = true;

    }
}
