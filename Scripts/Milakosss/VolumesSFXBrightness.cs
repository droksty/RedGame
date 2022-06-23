using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumesSFXBrightness : MonoBehaviour
{
    AudioSource audioS;
    public GameObject[] ost;

    public float volume;

    private void Awake() 
    {
        audioS = FindObjectOfType<AudioSource>();    
    }
    public void MusicChangeVolume(float volume)
    {
        audioS.volume = volume;
    }
}
