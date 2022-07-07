using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public GameObject optionsScreen;
    
    public AudioMixer theMixer;
    public TMP_Text mastLabel;
    public Slider mastSlider;


    // Start is called before the first frame update
    void Start()
    {
        optionsScreen.SetActive(false);
        
        //get the vvolume value stored in the player pref
        float vol = 0f;
        theMixer.GetFloat("MasterVol", out vol);
        mastSlider.value = vol;
        mastLabel.text = Mathf.RoundToInt(mastSlider.value + 80).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenOptions()
    {
        optionsScreen.SetActive(true);
    }
    
    public void CloseOptions()
    {
        optionsScreen.SetActive(false);
    }

    public void SetMasterVol()
    {
        mastLabel.text = Mathf.RoundToInt(mastSlider.value + 80).ToString();
        theMixer.SetFloat("MasterVol", mastSlider.value);
        
        //To save the value set by player
        PlayerPrefs.SetFloat("MasterVol", mastSlider.value);
    }

}
