using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singelton <T> : MonoBehaviour where T: Singelton<T>
{
   public static T Instance{get; private set;}

   public static bool Initialized{get{return Instance != null;} }

   protected virtual void Awake() 
   {
       if (Instance != null)
        Debug.LogError($"Trying to instantiate a second instance of singleton class{GetType().Name}");
        else
        Instance = (T)this;
   }

   protected virtual void OnDestory()
   {
       if (Instance == this)
       Instance = null;
   }
}
