using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] HealthBar healthBar;
    [SerializeField] Player player;

    private void Start()
    {
        healthBar.SetMaxHealth(player.maxHealth);
        healthBar.SetHealth(player.currentHealth);
    }

    private void OnEnable()
    {
        Eatable.OnEat += UpdateHealth;
    }

    private void OnDisable()
    {
        Eatable.OnEat -= UpdateHealth;
    }

    private void UpdateHealth(Food food)
    {
        player.currentHealth += food.healthiness;
        if (player.currentHealth > player.maxHealth)
        {
            player.currentHealth = player.maxHealth;
        }
        else if (player.currentHealth < 0)
        {
            player.currentHealth = 0;
        }
        player.vitality = player.currentHealth < player.maxHealth * 40 / 100 ? 0.6f : 1f;
        healthBar.SetHealth(player.currentHealth);
    }
}
