using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCubeInteraction : MonoBehaviour
{   

    /*
        Δημόσια μέθοδος με Bool check ώστε να ενεργοποιηθεί το αντικείμενο μόλις μαζευτούν τα 
        artifacts και να μην παίζει κονφλικτ με το raycaster .
    */

    public void ExitActivationToIgnoreLayers(bool activeCheck)
    {
        gameObject.SetActive(activeCheck);
    }
}
