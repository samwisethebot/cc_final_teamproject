using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformerController : MonoBehaviour
{

    //Speed of character movement and height of the jump. Set these values in the inspector.
    public float speed;
    public float jumpHeight;
 
  

    //Assigning a variable where we'll store the Rigidbody component.
    private Rigidbody rb;

  


    // Start is called before the first frame update
    void Start()
    {
        //Sets our variable 'rb' to the Rigidbody component on the game object where this script is attached.
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        

        //Movement code for a and d keys.
        if (Input.GetKey(KeyCode.A))
        {
            float finalSpeed = speed;
            
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            float finalSpeed = speed;
        
            
            rb.velocity = new Vector2(+speed, rb.velocity.y);
        }
        //ELSE if we're not pressing an arrow key, our velocity is 0 along the X axis, and whatever the Y velocity is (determined by jump)
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }


   
}
