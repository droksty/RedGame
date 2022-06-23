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
    public int newGame;
    public bool NewGame;

    public float time = 0.5f;
    

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
        StartCoroutine(WaitUntilLoad(time, nextScene));
        // nextScene = currentScene + 1;  
    }
    public void OnApplicationQuit() 
    {
        Application.Quit();    
    }

    IEnumerator WaitUntilLoad(float time, int nextScene)
    {
        Fader fader = FindObjectOfType<Fader>();

        yield return fader.FadeOut(time);

        yield return new WaitForSeconds(time);
        SceneManager.LoadSceneAsync(nextScene);


    }

    public void GameOverReloadScene()
    {
        SceneManager.LoadSceneAsync(currentScene);
    }



    // public void LoadScene(int sceneIndex)
    // {
    //     AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
    //     operation.progress
    // }
#endregion Scenes




}
