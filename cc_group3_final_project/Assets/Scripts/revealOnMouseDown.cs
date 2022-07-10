using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revealOnMouseDown : MonoBehaviour
{
    public GameObject visualsParent;
    bool hasTriggered;

    
    private void Awake()
    {
        //if we haven't assigned anything into the visuals parent slot, we can assume we want to hide the entire object
        if(visualsParent == null)
        {
            visualsParent = gameObject;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        visualsParent.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() 
    {
 
        if (Input.GetMouseButtonDown(0) && !hasTriggered)
        {
           visualsParent.gameObject.SetActive(true);
           hasTriggered = true;
        }
    }
}
