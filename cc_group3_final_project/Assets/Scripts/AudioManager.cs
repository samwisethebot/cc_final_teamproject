using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer theMixer;

    // To remember player choice for volume between sessions

    void Start()
    {
        if(PlayerPrefs.HasKey("MasterVol"))
        {
            theMixer.SetFloat("MasterVol", PlayerPrefs.GetFloat("MasterVol"));
        }
    }

    
}
