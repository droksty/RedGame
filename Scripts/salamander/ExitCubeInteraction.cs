using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCubeInteraction : MonoBehaviour
{   
    public void ExitActivationToIgnoreLayers(bool activeCheck)
    {
        gameObject.SetActive(activeCheck);
    }
}
