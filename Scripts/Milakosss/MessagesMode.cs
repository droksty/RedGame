using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MessagesMode : MonoBehaviour
{
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
