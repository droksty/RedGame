using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseWithESC : MonoBehaviour
{
    PauseMode pause;
    public GameObject btn;
    public bool escPauseCheck;

    public  void Start() 
    {
        escPauseCheck = false;
        pause = FindObjectOfType<PauseMode>();
    }
    // Update is called once per frame
    void Update()
    {
        if (escPauseCheck == false && Input.GetKeyDown(KeyCode.Escape))
        {
            escPauseCheck = true;
            pause.BoolCheck();
            btn.SetActive(true);
            escPauseCheck = false;
        }
    }
}
