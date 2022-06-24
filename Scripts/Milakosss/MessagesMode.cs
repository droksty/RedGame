using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MessagesMode : MonoBehaviour
{

    /*
    
        Λίστα Scriptable Objects που περιέχουν τα διαφορετικά κείμενα.
        κώδικας που ελέγχει ο Interaction controller για την μετάβαση και την ενεργοποίηση του message menu. 
        καλείται η showUI(string name) απο το UI COntroller.

        Μέθοδος MessageDisplay όπου καθορίζει ποιός αριθμός απο την λίστα άρα και πιο object θα προβληθεί όταν η ακτίνα raycaster θα χτυπήσει το ανάλογο object.
    */

    [SerializeField] TMP_Text text;
    [SerializeField] SO_[] messages;
    
    int messageListCounter;
    
    private void OnEnable() 
    {
        UIController.ShowUI("Message");  
         
    }

    public void MessageDisplay(int message)
    {
        text.text = messages[message].description; 
    }

    
}
