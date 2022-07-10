using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLoadScene : MonoBehaviour
{

    public string sceneToLoad;
    
    
    void OnMouseDown() 
    {
 
        if (Input.GetMouseButtonDown(0))
        {
           SceneManager.LoadScene(sceneToLoad);
        }
    }    
    
}
