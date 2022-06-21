using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMode : MonoBehaviour
{
    private void OnEnable() 
    {
        UIController.ShowUI("GameOver");    
    }
}
