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
    
    private Camera mainCamera;

    private void Awake()
    {
        controls = new CursorControls();   
        ChangeCursor(cursor);
        Cursor.lockState = CursorLockMode.Confined;
        mainCamera = Camera.main;
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
        DetectObject();
    }

    //Creating a function to know where we're clicking, using raycast from camera to the object
    private void DetectObject()
    {
        Ray ray = mainCamera.ScreenPointToRay(controls.Mouse.Position.ReadValue<Vector2>());
        RaycastHit hit;
    
        if(Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
            IClicked click = hit.collider.gameObject.GetComponent<IClicked>();
            if (click != null) click.onClickAction();
            Debug.Log("Hit Collider" + hit.collider.tag);
            }
        }      
    }


    private void ChangeCursor(Texture2D cursorType)
    {
        Cursor.SetCursor(cursorType, Vector2.zero, CursorMode.Auto);
    }

 
}
