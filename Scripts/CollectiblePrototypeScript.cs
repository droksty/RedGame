using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectiblePrototypeScript : MonoBehaviour
{
    private GameManager gameManager;

    [SerializeField] private float timeBoost = 25f; // Το boost σε timeLeft που κερδίζει ο παίκτης όταν μαζέψει ένα collectible


    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")  // Όταν ο παίκτης αγγίξει το object
        {
            Debug.Log(gameObject.name + " picked up by " + other.name);

            // reserved for κώδικα που έχει σχέση με το GAME OVER MECHANIC

            gameManager.collectibleCounter += 1;
            Debug.Log(gameManager.collectibleCounter);

            gameManager.timeLeft += timeBoost;

            //reserved for κώδικα που έχει σχέση με το GAME OVER MECHANIC
            
            Destroy(gameObject);
        }
    }
}
