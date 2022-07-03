using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    //Defining 2 states so we can switch based on input
    public Texture2D cursor;
    public Texture2D cursorClicked;

    //Refering to the cursor action map
    private CursorControls controls;

    private void Awake()
    {
        controls = new CursorControls();   
        ChangeCursor(cursor);
        Cursor.lockState = CursorLockMode.Confined;
    }
    
    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Start()
    {
        controls.Mouse.Click.started += _ => StartedClick();
        controls.Mouse.Click.performed += _ => EndedClick();
    }

    //Next two functions are to define cursor asset based on status
    private void StartedClick()
    {
        ChangeCursor(cursorClicked);
    }
    private void EndedClick()
    {
        ChangeCursor(cursor);
    }

    private void ChangeCursor(Texture2D cursorType)
    {
        
        Cursor.SetCursor(cursorType, Vector2.zero, CursorMode.Auto);
    }

 
}
