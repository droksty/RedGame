using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMode : MonoBehaviour
{
    public bool isPaused;

    public void BoolCheck()
    {
        isPaused = true;
    }

    public void BoolUncheck()
    {
        isPaused = false;
    }

    
    
}
