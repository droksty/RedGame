using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{
    public Texture2D texture;
    public bool vis;

    private void Start() 
    {
        Cursor.visible = vis;
        Cursor.SetCursor(texture, Vector2.zero, CursorMode.ForceSoftware);
    }
    public void CursorVisibility(bool cursor)
    {
        Cursor.visible = cursor;
    }

    private void Update() 
    {
        
    }
}
