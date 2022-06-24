using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumesSFXBrightness : MonoBehaviour
{
    /*
    
        Λίστα με το Soundtracks και μέθοδος για την αθξομείωση του ήχου στον INspector.

    */

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
