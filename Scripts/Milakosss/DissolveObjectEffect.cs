using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveObjectEffect : MonoBehaviour
{
    [SerializeField] GameObject gameObject;
    [SerializeField] public float EffectDuration;

    public void DisolveEffectBoolCheck()
    {
        Instantiate(gameObject, transform.position, transform.rotation);
        print("Effect");
    }

}
