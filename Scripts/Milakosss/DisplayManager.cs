using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayManager : MonoBehaviour
{
    ManageScenes scenes;
    public float timer; // Χρόνος που απομένει για Game Over
    public bool timerIsRunning = false;

    PauseMode pause;

    public TextMeshProUGUI[] CadranCounters; 

    private void Awake() 
    {
        pause = FindObjectOfType<PauseMode>();
        scenes = FindObjectOfType<ManageScenes>();  
    }
    private void Start() 
    {
        timerIsRunning = true;
    }
    void Update()
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
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        CadranCounters[2].text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }   
}
