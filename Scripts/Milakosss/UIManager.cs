using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject[] canvases = new GameObject[2];

#region Ui

    public void SettingsMenu()
    {
        canvases[0].SetActive(false);
        canvases[1].SetActive(true);
    }

#endregion Ui
}
