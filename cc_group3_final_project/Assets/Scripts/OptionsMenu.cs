using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject optionsScreen;
    // Start is called before the first frame update
    void Start()
    {
        optionsScreen.SetActive(false);
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
}
