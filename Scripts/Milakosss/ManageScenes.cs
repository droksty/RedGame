using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManageScenes : MonoBehaviour
{
    public int currentScene;
    public int nextScene;
    public int lastScene;
    private int newGame = 1;
    public bool NewGame;
    

# region Scenes

    private void Start() 
    {
        Scene scene = SceneManager.GetActiveScene();
        currentScene = scene.buildIndex;
        print("last scene is " + currentScene);
    }
    public void NewGameScene()
    {
        SceneManager.LoadSceneAsync(newGame);
        currentScene = 1;
        NewGame = true;
    }
    public void LoadNextScene(int sceneIndex)
    {
        // nextScene = currentScene + 1;
        SceneManager.LoadSceneAsync(nextScene);
    }
    public void OnApplicationQuit() 
    {
        Application.Quit();    
    }

    // public void LoadScene(int sceneIndex)
    // {
    //     AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
    //     operation.progress
    // }
#endregion Scenes




}
