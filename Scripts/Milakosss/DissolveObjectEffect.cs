using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveObjectEffect : MonoBehaviour
{
    [SerializeField] GameObject gameObject;
    [SerializeField] public float EffectDuration;

    /*  
        κώδικας ο οποίος δημιουργεί ένα παρτικλ εφεκτ καπνού όταν ο χρήστης συλλέξει κάποιο αντικείμενο.
        η δημιουργία γίνεται στις συντεταγμένες του αντικειμένου που έγινε destory απο το check collision..
    
    */


    public void DisolveEffectBoolCheck()
    {
        Instantiate(gameObject, transform.position, transform.rotation);
        print("Effect");
    }

}
