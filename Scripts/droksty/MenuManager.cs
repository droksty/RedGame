using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; ///

public class MenuManager : MonoBehaviour
{
    public void PlayGame() // 
    {
        SceneManager.LoadScene("Level2");
    }


    public void QuitGame() //
    {
        Debug.Log("Is this working??");
        Application.Quit();
    }
}
