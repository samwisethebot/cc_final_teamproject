using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicHandler : MonoBehaviour
{
    
     public enum Mode {EnsurePlaying, Restart, Stop};
     public Mode mode;
     void Start()
     {
         if (mode == Mode.EnsurePlaying)
             MusicPlay.musicplay.StartBackgroundMusic(false);
         else if (mode == Mode.Restart)
             MusicPlay.musicplay.StartBackgroundMusic(true);
         else if (mode == Mode.Stop)
             MusicPlay.musicplay.StopBackgroundMusic();
     }
 
}
