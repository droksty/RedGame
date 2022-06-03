// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsValues : MonoBehaviour
{
    public float music;
    public float SFX;
    public float Brightnness;

    public Slider slider;

    private void Awake() 
    {
        slider = GetComponent<Slider>();
    }

    private void SetValues()
    {
        slider.value = music;
        
    }
}
