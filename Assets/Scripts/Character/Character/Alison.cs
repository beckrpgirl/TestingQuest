using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Alison : MonoBehaviour
{
    public int maxHitPoints = 5;
    public int baseDamage = 10;
    private int PlayerCoins;
    public int PlayerStartCoins = 100;
    
    public CharController CC;
    public CharacterHealth healthBar;
    private int currentHealth;
    private int currentDamage;
    private float BaseRunSpeed;




    private void Start()
    {
        currentHealth = maxHitPoints;
        currentDamage = baseDamage;
        if(PlayerPrefs.GetInt("MoneyAmount") >= PlayerStartCoins)
        {
            PlayerCoins = PlayerPrefs.GetInt("MoneyAmount");
        } else
        {
            PlayerCoins = PlayerStartCoins;
        }

        CC = GetComponent<CharController>();
        if (CC)
        {
            BaseRunSpeed = CC.runSpeed;
        }
        healthBar = GetComponent<CharacterHealth>();
        if (healthBar)
            healthBar.SetMaxHealth(currentHealth);

    }

    private void Update()
    {
        if(healthBar.GetCurrentHealth() <= 0)
        {
            SceneManager.LoadScene("DeathScreen");
        }
    }

    public void DamageInc(int amount)
    {
        currentDamage += amount;
        print(currentDamage);
    }

    public void ResetDamage()
    {
        currentDamage = baseDamage;
    }
    public void IncreaseSpeed(int amount)
    {
        CC.runSpeed += amount;
    }
    public void ResetSpeed()
    {
        CC.runSpeed = BaseRunSpeed;
    }

    public void SetCoin(int amount)
    {
        PlayerCoins += amount;
        PlayerPrefs.SetInt("MoneyAmount", PlayerCoins);
    }

    public int GetCoin()
    {
        return PlayerCoins;
    }



}
