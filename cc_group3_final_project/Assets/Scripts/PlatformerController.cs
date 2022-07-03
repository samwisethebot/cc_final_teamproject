using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlatformerController : MonoBehaviour
{

    //Speed of character movement and height of the jump. Set these values in the inspector.
    public float speed;
    public float jumpHeight;
  

    //Assigning a variable where we'll store the Rigidbody component.
    private Rigidbody rb;

    private bool onGround;
    private bool canJump;

    private float inputX;


    // Start is called before the first frame update
    void Start()
    {
        //Sets our variable 'rb' to the Rigidbody component on the game object where this script is attached.
        rb = GetComponent<Rigidbody>();

    }

    
    void Update()
    {
       
        rb.velocity = new Vector2(inputX * speed, rb.velocity.y);
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


    public void Move(InputAction.CallbackContext context)
    {
        inputX = context.ReadValue<Vector2>().x;
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if(context.performed && onGround == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }

    }

}
