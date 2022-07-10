using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLoadScene : MonoBehaviour
{

    public string sceneToLoad;
    
    // Start is called before the first frame update
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
