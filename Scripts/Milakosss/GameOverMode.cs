using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMode : MonoBehaviour
{

/*

 κώδικας που ελέγχει ο Interaction controller για την μετάβαση και την ενεργοποίηση του game over. 
            καλείται η showUI(string name) απο το UI COntroller.

*/



    private void OnEnable() 
    {
        UIController.ShowUI("GameOver");    
    }
}
