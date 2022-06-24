using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Descriptiom", order = 1)]
public class SO_ : ScriptableObject
{

    /*
        Δημιουργία asset scriptable object με μια μεταβλητή κειμένου τύπου string
        για την τοποθέτηση των κειμένων όπου εξηγούνται τα σύμβολα ελπίδας μέσα στην απαιλπισία.
    */

    [TextArea(2,6)]
    public string description;
}
