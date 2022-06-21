using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{



    private void Start() 
    {
        Cursor.visible = false;
    }
    public void CursorVisibility(bool cursor)
    {
        Cursor.visible = cursor;
    }

    private void Update() 
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
        cursorPos = transform.forward;
          
    }
}
