using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMode : MonoBehaviour
{
    
    public bool isPaused;

    public void BoolCheck()
    {
        isPaused = true;
        Cursor.visible = true;
    }

    public void BoolUncheck()
    {
        isPaused = false;
        Cursor.visible = false;
    }

    
    
}
