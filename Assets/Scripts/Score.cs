using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] TextMeshProUGUI scoreText;
    private int score;

    private void Start()
    {
        score = 0;
    }

    private void OnEnable()
    {
        Eatable.OnEat += UpdateScore;
    }

    private void OnDisable()
    {
        Eatable.OnEat -= UpdateScore;
    }

    private void UpdateScore(Food food)
    {
        score += food.healthiness;
        scoreText.text = "Score : " + score;
    }
}
