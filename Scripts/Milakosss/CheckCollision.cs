using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    [SerializeField] private float timeBoost = 25f; // Το boost σε timeLeft που κερδίζει ο παίκτης όταν μαζέψει ένα collectible
    [HideInInspector] public int collectibleCounter; // Το σύνολο των collectible που έχει μαζέψει ο παίκτης
    [HideInInspector] public int artifactCounter; // Το σύνολο των artifact που έχει μαζέψει ο παίκτης

    void OnTriggerEnter(Collider other) // Έλεγχος για Α. collectible B. Artifact C. Exit
    {
       DisplayManager displayManager = FindObjectOfType<DisplayManager>();

        if (gameObject.tag == "Player" && other.tag == "Collectable") 
        { // collectable
        
            // Debug.Log(gameObject.name + " picked up by " + other.name);

            // reserved for κώδικα που έχει σχέση με το GAME OVER MECHANIC

            collectibleCounter += 1;
        
            displayManager.CadranCounters[0].text = collectibleCounter.ToString();

            displayManager.timer += timeBoost;

            //reserved for κώδικα που έχει σχέση με το GAME OVER MECHANIC
            print("collect");
            Destroy(other.gameObject);

        }
        else if (gameObject.tag == "Player" && other.tag == "Artifact") 
        { // artifacts
        
            // Debug.Log(gameObject.name + " picked up by " + other.name);
            artifactCounter += 1;
            displayManager.CadranCounters[1].text = artifactCounter.ToString();

            // reserved for κώδικα που έχει σχέση με Level Advancement
            Destroy(other.gameObject);
            print("Artifact");
        }
        else if (gameObject.tag == "Player" && other.tag == "Exit") 
        { // exit
            
            ManageScenes sceneManager = FindObjectOfType<ManageScenes>();
            sceneManager.LoadNextScene(sceneManager.currentScene + 1);
           
            Debug.Log("Level Complete, go to next Level");
            
            // reserved for κώδικα που έχει σχέση με Level Advancement
        }
    }
        

}
