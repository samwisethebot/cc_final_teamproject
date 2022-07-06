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

    private bool onGround;
    private bool canJump;


    // Start is called before the first frame update
    void Start()
    {
        //Sets our variable 'rb' to the Rigidbody component on the game object where this script is attached.
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //Check if the player is on the ground. If we are, then we are able to jump.
        if (onGround == true)
        {
            canJump = true;
        }
        //If we're able to jump and the player has pressed the space bar, then we jump!
        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            rb.velocity = Vector2.up * jumpHeight;
            canJump = false;
        }


        //Movement code for left and right arrow keys.
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float finalSpeed = speed;
            if (onGround == false)
            {
                finalSpeed *= 0.5f;
            }
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            float finalSpeed = speed;
            if (onGround == false)
            {
                finalSpeed *= 0.5f;
            }
            rb.velocity = new Vector2(+speed, rb.velocity.y);
        }
        //ELSE if we're not pressing an arrow key, our velocity is 0 along the X axis, and whatever the Y velocity is (determined by jump)
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        //If we collide with an object tagged "ground" then our jump resets and we can now jump.
        if (collision.gameObject.tag == "Ground")
        {
            onGround = true;
            
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        //If we exit our collision with the "ground" object, then we are unable to jump.
        if (collision.gameObject.tag == "Ground")
        {
            onGround = false;
            
        }
    }
}
