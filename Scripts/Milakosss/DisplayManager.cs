using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayManager : MonoBehaviour
{
    AudioSource audio;

    ManageScenes scenes;
    public float timer = 180; // Χρόνος που απομένει για Game Over
    public bool timerIsRunning = false;
    public bool SuspenceSoundTimerBool;

    PauseMode pause;

    public TextMeshProUGUI[] CadranCounters;

    private void Awake() 
    {
        pause = FindObjectOfType<PauseMode>();
        scenes = FindObjectOfType<ManageScenes>();
        audio = GetComponent<AudioSource>();  
    }
    private void Start() 
    {
        timerIsRunning = true;
    }
    public void Update()
    {
        if (pause.isPaused == true)
        {
                timerIsRunning = false;
                print ("timercheck");
                // Time.timeScale = 0;
        }

        if (timerIsRunning == true || timerIsRunning == false && pause.isPaused == false)
        {
            if (timer > 0) 
            {

                timer -= Time.deltaTime;
                CadranCounters[2].text = timer.ToString("#.0");
                
            }
            else 
            {
                CadranCounters[2].text = 0.ToString();
                CadranCounters[3].gameObject.SetActive(true);

            }
            DisplayTime(timer);
        }
        if(timer <= 60)
        {
            // print("Click Clack");
            // audio.Play();
        }      
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        CadranCounters[2].text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void DisplayMessage(string msg)
    {
        // show msg
    }   
}
