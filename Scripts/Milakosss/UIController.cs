using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotaryHeart.Lib.SerializableDictionary;
using DG.Tweening;

/*
    κα΄νουμε serialize στην cached μνημη του υπολογιστή την βιβλιοθήκη και για να φαίνεται στον ινσπέκτορ.
*/

[System.Serializable]
public class UIPanelDictionary: SerializableDictionaryBase<string, CanvasGroup>{}

public class UIController : Singelton<UIController>
{
    [SerializeField] UIPanelDictionary uiPanels;
    CanvasGroup currentPanel;

    protected override void Awake() 
    {
        base.Awake();
        ResetAllUI();    
    }

    /*
        reset όλων των Ui elements που βρίσκονται στο canvas Group.
    */
    public void ResetAllUI()
    {
        foreach (CanvasGroup panel in uiPanels.Values)
        {
            panel.gameObject.SetActive(false);
        }
    }

    /*
        singleton pattern apo to singleton για να μην χαθεί κάποιο σε μετάβαση σκηνής.

        Παρακάτω βλέπουμε την _ShowUI(string name). Η μέθοδος αυτή καλείται για να ενεργοποιήσει το κάθε mode
        στο παιχνίδι μας αλλά και ελέγψει τηην ομαλή μετάβαση απο το ένα στο άλλο χωρίς jitters
    */

    public static void ShowUI(string name)
    {
        Instance?._ShowUI(name);
    }

    void _ShowUI(string name)
    {
        CanvasGroup panel;
        if (uiPanels.TryGetValue(name, out panel))
        {
            ChangeUI(uiPanels[name]);
        }
        else
        {
            Debug.LogError("Undefined ui panel " + name);
        }
    }

    /*
        Έλεγχος της μετάβασης των UI
    */
    public void ChangeUI(CanvasGroup panel)
    {
        if (panel == currentPanel)
            return;
        if (currentPanel)
            FAdeOut(currentPanel);
            currentPanel = panel;
        if (panel)
            FadeIn(panel);
    }

    /*
        Fade in - out animation μεσω ενός package για ομαλή μετάβαση των UI
    */

    void FadeIn(CanvasGroup panel)
    {
        panel.gameObject.SetActive(true);
        panel.DOFade(1f, 0.5f);
    }

    void FAdeOut(CanvasGroup panel)
    {
        panel.DOFade(0, 0.5f).OnComplete(() => panel.gameObject.SetActive(false));
    }
}

