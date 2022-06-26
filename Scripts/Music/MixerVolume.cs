using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerVolume : MonoBehaviour
{

    /*
        Ο κώδικας εχει ενα πεδίο οπου επισυνάπτεται τοαντικείμενο audio mixer
        και δύο δημόσιες μεθόδους τυπου float όπου μεταχειρίζονται το τελικό 
        λέβελ του μαστερ ήχου ξεχωριστα για το γκρουπ περιβα΄λοντος και ξεχωριστά
        για το OST. και πολλαπλασιάζουν με την λογαριθμηκότητα που μετρατριλεται ο 
        ήχος σε DBspl. Για να διαχειρίζεται απο το UI SLIDER.
    */


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
