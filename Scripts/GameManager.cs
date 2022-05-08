using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public int collectibleCounter; // Το σύνολο των collectible που έχει μαζέψει ο παίκτης
    [HideInInspector] public float timeLeft; // Χρόνος που απομένει για Game Over

    [SerializeField] private float timeToDie = 25f; // Χρόνος που απομένει για Game Over κατά την έναρξη


    void Start()
    {
        timeLeft = timeToDie;
    }


    void Update()
    {
        if (timeLeft > 0) {
            timeLeft -= 1 * Time.deltaTime;
            Debug.Log(timeLeft);
        } else {
            Debug.Log("GAME OVER");
        }
    }
}
