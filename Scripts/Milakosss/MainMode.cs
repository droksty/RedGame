using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMode : MonoBehaviour
{
     /*κώδικας που ελέγχει ο Interaction controller για την μετάβαση και την ενεργοποίηση του main menu. 
            καλείται η showUI(string name) απο το UI COntroller.*/
    private void OnEnable() 
    {
        UIController.ShowUI("Main");  
    }
}
