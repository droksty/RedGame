using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Rendering.Universal;

public class BrightnessLight : MonoBehaviour
{
    
    private ColorAdjustments col;
    public float minBright;
    public float maxBright;

    private void Start() 
    {
        col = FindObjectOfType<ColorAdjustments>();
    }

    public void ColorAdjusmentChange(float volCol)
    {
        col.postExposure.value = Mathf.Clamp(volCol, minBright, maxBright);
    }

}
