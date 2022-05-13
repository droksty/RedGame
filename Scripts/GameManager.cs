using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public int collectibleCounter; // Το σύνολο των collectible που έχει μαζέψει ο παίκτης
    [HideInInspector] public int artifactCounter; // Το σύνολο των artifact που έχει μαζέψει ο παίκτης
    [HideInInspector] public float timer; // Χρόνος που απομένει για Game Over

    [SerializeField] private float timeLeft = 10f; // Χρόνος που απομένει για Game Over κατά την έναρξη

    public TextMeshProUGUI countdown;
    public TextMeshProUGUI gameOver;
    public TextMeshProUGUI collectiblesCollected;
    public TextMeshProUGUI artifactsCollected;


    void Start()
    {
        timer = timeLeft;
    }


    void Update()
    {
        if (timer > 0) {
            timer -= 1 * Time.deltaTime;
            countdown.text = timer.ToString("#.0");
        } else {
            countdown.text = 0.ToString();
            gameOver.gameObject.SetActive(true);
        }
    }
}
