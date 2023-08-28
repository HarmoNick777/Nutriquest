using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateFoodTMP : MonoBehaviour
{
    [Serializable] public struct FoodUIPair
    {
        public Food food;
        public TMP_Text tmp;
    }

    [SerializeField] FoodUIPair[] pairs;

    private void OnEnable()
    {
        Eatable.OnEat += UpdateTMP;
    }

    private void OnDisable()
    {
        Eatable.OnEat -= UpdateTMP;
    }

    private void UpdateTMP(Food food)
    {
        TMP_Text tmp = null;
        foreach (FoodUIPair pair in pairs)
        {
            if (pair.food.Equals(food))
            {
                tmp = pair.tmp;
                break;
            }
        }

        tmp.text = "<sprite name=\"" + food.name + "\"> : " + food.eaten;
    }
}
