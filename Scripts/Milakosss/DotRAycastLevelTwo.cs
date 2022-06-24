using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotRAycastLevelTwo : MonoBehaviour
{
    public string[] LayerNames;
    public GameObject exit;
    ManageScenes sceneManager;

    public float maxDistance = 10f;
    private void Start() 
    {
        sceneManager = FindObjectOfType<ManageScenes>();
    }

    /*
    
        Μια λίστα απο layers τα οποία σε περίπτωση που έρθει σε πεαφή με την ακτίνα του raycast
        προβάλλεται το UI menu με τα κείμενα και προβάλει το κατάλληλο κείμενο ανάλογα με τo layer poy διαβάζει.
        
    
    */


    private void FixedUpdate() 
    {
        int layerMaskAnchor = LayerMask.GetMask(LayerNames[0]);
        int layerMaskOrigami = LayerMask.GetMask(LayerNames[1]);
        int layerMaskDove = LayerMask.GetMask(LayerNames[2]);
        int layerMaskCornucopia = LayerMask.GetMask(LayerNames[3]);
        int Exit = LayerMask.GetMask(LayerNames[4]);
        


        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(transform.position);
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(ray, out hit, maxDistance, layerMaskAnchor))
        {
            
            Debug.Log("Hit Anchor");


            UIController.ShowUI("Message");
            FindObjectOfType<MessagesMode>().MessageDisplay(2);

            // if (Input.GetKeyDown(KeyCode.E)) 
            // {
            //     Destroy(exit);
            //     sceneManager.LoadNextScene(2);
            // }    
        }
        else if (Physics.Raycast(ray, out hit, maxDistance, layerMaskOrigami))
        {
            Debug.Log("Hit Origami");


            UIController.ShowUI("Message");
            FindObjectOfType<MessagesMode>().MessageDisplay(4);
        }
        else if (Physics.Raycast(ray, out hit, maxDistance, layerMaskDove))
        {
            Debug.Log("Hit Dove");


            UIController.ShowUI("Message");
            FindObjectOfType<MessagesMode>().MessageDisplay(3);
        }
        else if (Physics.Raycast(ray, out hit, maxDistance, layerMaskCornucopia))
        {
            Debug.Log("Hit Cornucopia");


            UIController.ShowUI("Message");
            FindObjectOfType<MessagesMode>().MessageDisplay(5);
        }
        else if (Physics.Raycast(ray, out hit, maxDistance, Exit))
        {
            if (FindObjectOfType<CheckCollision>().exitOpen == true)
            {
                Debug.Log("Exit");


                UIController.ShowUI("Message");
                FindObjectOfType<MessagesMode>().MessageDisplay(1);

                if (Input.GetKeyDown(KeyCode.E)) 
                    {
                    sceneManager.LoadNextScene(sceneManager.currentScene + 1);
                    Debug.Log("Level Complete, go to next Level");
                    }   
            }
            else
            {
                UIController.ShowUI("Message");
                FindObjectOfType<MessagesMode>().MessageDisplay(0);
            }

        }
        else {UIController.ShowUI("Game");}

    }
}
