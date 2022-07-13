using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearOnTimer : MonoBehaviour
{
    public GameObject Button;
    public float timer;
    

    private void Start()
    {
        Button.SetActive(false);
        FunctionTimer.Create(makeButtonAppear, timer);
    }

    

    private void makeButtonAppear()
    {
        Button.SetActive(true);
    }
}
