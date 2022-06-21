using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotaryHeart.Lib.SerializableDictionary;
using DG.Tweening;

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
    public void ResetAllUI()
    {
        foreach (CanvasGroup panel in uiPanels.Values)
        {
            panel.gameObject.SetActive(false);
        }
    }
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

