using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundOnMouseDown : MonoBehaviour
{
    public AudioClip tomeSfx;
    private AudioSource audioSource;
   
    void Start () 
    {
        audioSource = gameObject.GetComponent<AudioSource> ();
          
    }
   
    void OnMouseOver() 
    {
 
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.enabled = true;
            if (!audioSource.isPlaying) 
            {
                audioSource.clip = tomeSfx;
                audioSource.Play ();
            }
        }
    }    
}