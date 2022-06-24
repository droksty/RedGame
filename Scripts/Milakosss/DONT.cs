using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DONT : MonoBehaviour
{
    /*
        ένα singleton pattern απλό για αντικείμενα για διατήρηση αντικειμένων απο σκηνή σε σκηνή.
        ο κώδικας τελικά ήταν ελλατωματικός και εξελήχθηκε στο script Singleton
    */
    public static DONT instance;

    public void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
