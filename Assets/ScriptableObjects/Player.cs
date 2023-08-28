using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player", menuName = "ScriptableObjects/Player")]
public class Player : ScriptableObject
{
    [NonSerialized] public int maxHealth = 50;
    [NonSerialized] public int currentHealth = 40;
    [NonSerialized] public float vitality = 1f;
}