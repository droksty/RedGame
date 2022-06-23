using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseWithESC : MonoBehaviour
{
    PauseMode pause;
    public GameObject btn;
    // public GameObject img;
    public bool escPauseCheck;
    public bool isPuased;

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
            // img.SetActive(true);
                escPauseCheck = false;
                isPuased = true;
        }
    }
}
