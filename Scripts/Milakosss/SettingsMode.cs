using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMode : MonoBehaviour
{
    private void OnEnable() 
    {
        UIController.ShowUI("Settings");    
    }
}
