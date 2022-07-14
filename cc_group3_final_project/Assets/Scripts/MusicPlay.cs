using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlay : MonoBehaviour
{
     
     public static MusicPlay musicplay;
     // either set backgroundMusic in the inspector or use GetComponent in Awake to initialize this variable
     public AudioSource backgroundMusic;
 
      void Awake()
      {
          if (musicplay == null)
          {
              DontDestroyOnLoad(gameObject);
              musicplay = this;
          }
          else if (musicplay != this)
          {
              Destroy(gameObject);
          }
          
      }
     public void StartBackgroundMusic(bool aRestart)
     {
         if (!backgroundMusic.isPlaying || aRestart)
             backgroundMusic.Play();
     }
     public void StopBackgroundMusic()
     {
         backgroundMusic.Stop();
     }
 
    
}
