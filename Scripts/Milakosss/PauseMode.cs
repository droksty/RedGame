using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMode : MonoBehaviour
{

    /*
    
        Οι δημόσιες μέθοδοι πειροδοτούν τις bool check εαν το παιχνίδι είναι σε παυση.
        οι οπόί ες καθορίζονται και απο τα UI Buttons.
        Επίσης κάνει ορατό και μη τον κέρσορα. ορατό οταν είναι σε παύση και μη ορατό οταν είναι σε παύση.
    
    */
    
    public bool isPaused;

    public void BoolCheck()
    {
        isPaused = true;
        Cursor.visible = true;
    }

    public void BoolUncheck()
    {
        isPaused = false;
        Cursor.visible = false;
    }

    
    
}
