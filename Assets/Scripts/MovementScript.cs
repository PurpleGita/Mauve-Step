using System;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void MovementXAxis(Vector2 Xmovement)
    {

        //flip sprite to face the direction of movement
        if (Xmovement.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (Xmovement.x > 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }

        //check for collision

        //do the run animation or walk animation based on speed (talk to animation handler)




        //actual movement
        transform.Translate(Xmovement * Time.deltaTime);

    }

    void MovementZAxis(Vector3 Zmovement)
    {
        Debug.Log("Zmovement: " + Zmovement);

        //check for collision

        //do the run animation or walk animation based on speed (talk to animation handler)




        //actual movement
        transform.Translate(Zmovement * Time.deltaTime);
    }

    public void ReciveInput(Vector2 direction)
    {
        //send the direction y to the method that moves the player on the z axis
        Vector3 directionz = new Vector3(0, 0, (direction.y/10));
        MovementZAxis(directionz);


        //send the direction x to the method that moves the player on the x axis
        Vector2 directionx = new Vector2((direction.x/10), 0);
        MovementXAxis(directionx);

       
    }
}
