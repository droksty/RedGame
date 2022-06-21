using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Descriptiom", order = 1)]
public class SO_ : ScriptableObject
{
    [TextArea(2,6)]
    public string description;
}
