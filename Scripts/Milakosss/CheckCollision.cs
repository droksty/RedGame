using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    AudioSource audio;
    public AudioClip[] clip;
    DissolveObjectEffect disolve;
    
    [Range(0, 1)]
    public float artifactVolume = 0.7f;
    [Range(0, 1)]
    public float collectableVolume = 0.7f;

    [SerializeField] private float timeBoost = 25f; // Το boost σε timeLeft που κερδίζει ο παίκτης όταν μαζέψει ένα collectible
    [HideInInspector] public int collectibleCounter; // Το σύνολο των collectible που έχει μαζέψει ο παίκτης
    [HideInInspector] public int artifactCounter; // Το σύνολο των artifact που έχει μαζέψει ο παίκτης

    GameObject door;
    GameObject chest;

    private void Awake() 
    {
        disolve = FindObjectOfType<DissolveObjectEffect>();
        audio = GetComponent<AudioSource>();
        
    }


    public void OnTriggerEnter(Collider other) // Έλεγχος για Α. collectible B. Artifact C. Exit
    {
       DisplayManager displayManager = FindObjectOfType<DisplayManager>();

        if (other.tag == "Collectable") 
        { // collectable
            audio.PlayOneShot(clip[1], collectableVolume);
            //Debug.Log(gameObject.name + " picked up by " + other.name);

            // reserved for κώδικα που έχει σχέση με το GAME OVER MECHANIC

            collectibleCounter += 1;
        
            displayManager.CadranCounters[0].text = collectibleCounter.ToString();

            displayManager.timer += timeBoost;

            //reserved for κώδικα που έχει σχέση με το GAME OVER MECHANIC
            print("collect");
            Destroy(other.gameObject);
        }
        else if (other.tag == "Artifact") 
        { // artifacts
            audio.PlayOneShot(clip[0], artifactVolume);
            // Debug.Log(gameObject.name + " picked up by " + other.name);
            artifactCounter += 1;
            displayManager.CadranCounters[1].text = artifactCounter.ToString();

            // reserved for κώδικα που έχει σχέση με Level Advancement
            Destroy(other.gameObject);
            print("Artifact");
          
        }
        else if (other.tag == "Door")
        {
            if (artifactCounter == 7)
            {
                //trigger door animation
                door = GameObject.FindWithTag("Door");
                door.GetComponent<Animator>().Play("DoorOpen");
            }
            else
            {
                //displayManager.DisplayMessage("The door is locked, you need all 7 artifacts to unlock it.");
                Debug.Log("Door is locked");
            }
        }
        else if (other.tag == "Chest")
        {
            chest = GameObject.FindWithTag("Chest");
            chest.GetComponentInChildren<Animator>().Play("ChestOpen");
        }
        else if (other.tag == "Exit") 
        { // exit
            
            ManageScenes sceneManager = FindObjectOfType<ManageScenes>();
            sceneManager.LoadNextScene(sceneManager.currentScene + 1);
           
            Debug.Log("Level Complete, go to next Level");
            
            // reserved for κώδικα που έχει σχέση με Level Advancement
        }
    }
}
