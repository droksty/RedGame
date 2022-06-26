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
    

    /*
        Οι μεταβλητές ορίζονται στον ινσπέλτορ της κάθε σκηνής.
        Oi παρακατω μέθοδοι είναι υπεύθηνοι για την λειτουργία του scene managment.

        H quitapplication μας βοηθάει στην έξοδο απο το αρχείο παιχνιδιού.
        Η NewGame μας λέει ποια σκηνή είναι όταν ξεκινάει το παιχνίδι.
        Η LoadNextScene αλλάζει στην επόμενη σκηνή μόλις ο παίκτης κάνει τις ανάλογες πράξεις τερματισμού της σκηνής.
        εκτός απο κάποια σημεία τα οποία είναι exit point πειροδοτείτε και απο UI Buttons όπουθ πρέπει να του ορίσουμε την μεταβλητή στην ONclick event του εκάστοτε button.

        H WaituntilLoad είναι ένας enumerator υπεύθυνος για την καθυστέρηση της ασύγχρονης ενναλλαγής σκηνών όπου τα δευτερόλεπτα ορίζονται και απο τον ινσπέκτορ.
        Η Gameover απλά σε επαναφέρει στο ρισταρτ ποιντ της ίδιας σκηνής που ο χρήστης δεν κατάφερε να ολοκληρώσει πριν το πέρασμα του χρόνου.
    */


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
