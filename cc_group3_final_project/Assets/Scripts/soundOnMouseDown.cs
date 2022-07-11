using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundOnMouseDown : MonoBehaviour
{
    public AudioClip valvesfx;
    private AudioSource audioSource;
   
    public bool onlyPlayOnce;
    bool hasTriggered;

    void Start () {
        audioSource = gameObject.GetComponent<AudioSource> ();
   
       
    }
    void OnMouseDown() 
    {
 
        if (Input.GetMouseButtonDown(0) && hasTriggered == false)
        {
           audioSource.enabled = true;
           if (!audioSource.isPlaying) 
           {
                audioSource.clip = valvesfx;
                audioSource.Play ();
           }
           if (onlyPlayOnce == true)
        {
            hasTriggered = true;
        }
        }
    }    
}