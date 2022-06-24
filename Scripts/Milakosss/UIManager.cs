using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    /*
    
        Λίστα με διαφορετικά UI Canvases και μέθοδος ενναλαγής απο κάποιο UI στο settings UI.

    */

    public GameObject[] canvases = new GameObject[2];

#region Ui

    public void SettingsMenu()
    {
        canvases[0].SetActive(false);
        canvases[1].SetActive(true);
    }

#endregion Ui
}
