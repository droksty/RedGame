using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerVolume : MonoBehaviour
{
    [SerializeField] public AudioMixer mixer;

    public void MixerVol(float vol)
    {
        mixer.SetFloat("OST", Mathf.Log10(vol) * 20);
    }

    public void SFXVol(float vol)
    {
        mixer.SetFloat("Enviroment", Mathf.Log10(vol) * 20);
    }
}
