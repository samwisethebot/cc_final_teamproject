using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    //Which AudioSource are we using
    //Set this in the inspector on the script
    public AudioSource soundSource;
    public bool onlyPlayOnce;
    bool hasTriggered;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //if we detect a collision, and the object we collided with is the player
        //play the AudioSource 
        if (other.gameObject.tag == "Player" && hasTriggered == false)
        {
            soundSource.Play();
           
            if (onlyPlayOnce == true)
        {
            hasTriggered = true;
        }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        //if we detect a collision, and the object we collided with is the player
        //play the AudioSource 
        if (other.gameObject.tag == "Player" && hasTriggered)
        {
            soundSource.Play();
            
            if (onlyPlayOnce == true)
        {
            hasTriggered = true;
        }
        }
    }

}
