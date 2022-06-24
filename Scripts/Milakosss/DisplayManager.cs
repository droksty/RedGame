using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayManager : MonoBehaviour
{
    /*
    
        έλεγχος του χρόνου αμα τελειώσει να γίνει το τέλος του παιχνιδιού. 
        Έλεγχος του χρόνου να σταματάει όταν γίνεται παύση στο παιχνίδι.
        
    
    */




    AudioSource audio;

    ManageScenes scenes;
    public float timer = 180; // Χρόνος που απομένει για Game Over
    public bool timerIsRunning = false;
    public bool SuspenceSoundTimerBool;
    public bool gameOver;
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
        gameOver = false;
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
                for (int i = 0; i < CadranCounters.Length - 1; i++)
                {
                    CadranCounters[i].gameObject.SetActive(false);
                }
                
                UIController.ShowUI("GameOver");
                gameOver = true;
                StartCoroutine(GameOverWait(1));
                ;
            }
            DisplayTime(timer);
        }
        if(timer <= 60)
        {
            // print("Click Clack");
            // audio.Play();
        }      
    }



        /*
            Οπτικοποίηση των αριθμών 180 σεκοντς σε προβολή ρολογιού
        
        */
    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        CadranCounters[2].text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    /*
    
        Enumerator που στην περίπτωση του Game over υπάρχει μια μικρή καθυστέρηση πριν το reload.
    */

    IEnumerator GameOverWait(float time)
    {
        yield return new WaitForSeconds(time);
        scenes.GameOverReloadScene();
    }
}
