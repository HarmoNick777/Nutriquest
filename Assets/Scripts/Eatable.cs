using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Eatable : MonoBehaviour
{
    [SerializeField] Food food;
    
    public static event Action<Food> OnEat;

    private void OnTriggerEnter()
    {
        Destroy(gameObject);
        food.eaten++;
        OnEat?.Invoke(food);
    }
}
