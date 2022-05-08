using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectiblePrototypeScript : MonoBehaviour
{

    void Start()
    {
        
    }


    void OnTriggerEnter(Collider other) // Collectible
    {
        if(other.name == "Player") { // Όταν ο παίκτης αγγίξει το object
            Debug.Log("Picked up by " + other.name);
            // reserved for κώδικα που έχει σχέση με το GAME OVER MECHANIC
            Destroy(gameObject);
        }
    }
}
