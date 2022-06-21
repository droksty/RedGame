using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotRaycast : MonoBehaviour
{   
    public GameObject exitCube;
    ManageScenes sceneManager;
    private void Start() 
    {
        sceneManager = FindObjectOfType<ManageScenes>();
    }

    private void FixedUpdate() 
    {
        int layerMask = LayerMask.GetMask("Interact");
        


        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(transform.position);
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {
            
            Debug.Log("Did Hit");


            UIController.ShowUI("Message");
            FindObjectOfType<MessagesMode>().MessageDisplay(1);

            if (Input.GetKeyDown(KeyCode.E)) 
            {
                Destroy(exitCube);
                sceneManager.LoadNextScene(2);
            }    
        }
    }
}
