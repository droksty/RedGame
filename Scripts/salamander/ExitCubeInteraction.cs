using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCubeInteraction : MonoBehaviour
{   
    GameObject player;
    CheckCollision plrScript;
 

    // Start is called before the first frame update
    void Awake()
    {
        DisplayManager displayManager = FindObjectOfType<DisplayManager>();
        player = GameObject.FindWithTag("Player");
        plrScript = player.GetComponent<CheckCollision>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        Debug.Log("mouse hovers over the GameObject");

        if (plrScript.isChestOpen) {
            //displayManager.DisplayMessage("Touch [E]");
            Debug.Log("Touch cube [E]");
            if (Input.GetKeyDown(KeyCode.E)) {
                Destroy(gameObject);
                // load Scene 2
            }
        }
    }

    void OnMouseExit()
    {
        Debug.Log("The mouse is no longer hovering over the GameObject");
        //hide message
    }
}
