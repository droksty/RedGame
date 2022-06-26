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


    /*
        Δημιουργία ακτίνας ελέγχου αντικειμένου πρώτης πίστας διαβάζοντας το layer INteract.
        an ο χρήστης κεντραρει πάνω στο αντικείμενο εμφανίζεται απο τον UICOntroller το UI κειμένων με τα scriptable objects
        και τον ωθεί στο να έρθει σε διεπαφή μαζί του με το πλήκτρο Ε. εαν έρθει το αντικείμενο exit cube καταστρέφεται και φορτώνεται η επόμενη σκκηνή.
    
    */

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
