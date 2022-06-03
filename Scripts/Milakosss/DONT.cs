using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DONT : MonoBehaviour
{
    public static DONT instance;

    public void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
