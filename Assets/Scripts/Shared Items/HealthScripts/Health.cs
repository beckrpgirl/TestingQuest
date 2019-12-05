using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Health : MonoBehaviour
{
    private int maxHealth = 0;
    private int currentHealth = 0;

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
    }

    public void Heal(int amount)
    {
         currentHealth += amount;
    }

    public void SetMaxHealth(int value)
    {
        maxHealth = value;
        currentHealth = maxHealth;
    }

    public int GetMaxHealth()
    {
        return maxHealth;
    }

    public int GetCurrentHealth()
    {
        return currentHealth;
    }

    public float NormalizeHealth()
    {
        return (float)currentHealth / maxHealth;
    }
}
