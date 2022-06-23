using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour
{
 CanvasGroup canvasGroup;

        private void Start() 
        {
            canvasGroup = GetComponent<CanvasGroup>();
            StartCoroutine(FadeIn(3));
        }
 
        public IEnumerator FadeOut(float time)
        {
            while (canvasGroup.alpha < 1)
            {
                canvasGroup.alpha += Time.deltaTime / time;
                print("fadeOut");
                yield return null;
            }

        }
        public IEnumerator FadeIn(float time)
        {
            
            while(canvasGroup.alpha > 0)
            {
                canvasGroup.alpha -= Time.deltaTime / time;
                print("fadeIn");
                yield return null;
            }
        }
}
