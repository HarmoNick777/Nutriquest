using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "New Food", menuName = "ScriptableObjects/Food")]
public class Food : ScriptableObject
{
    public int healthiness;
    [NonSerialized] public int eaten = 0;
}