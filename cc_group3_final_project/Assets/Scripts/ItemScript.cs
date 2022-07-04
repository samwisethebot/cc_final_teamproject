using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour, IClicked
{
    public void onClickAction()
    {
        Destroy(gameObject);
    }
    
}
