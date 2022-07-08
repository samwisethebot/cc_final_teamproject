using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorStyle : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotspot = Vector2.zero;

    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, hotspot, cursorMode);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}
