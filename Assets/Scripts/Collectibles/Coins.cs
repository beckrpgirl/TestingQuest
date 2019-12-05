using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coins : BaseCollectible
{

    public int worth;


    public override void ApplyEffect()
    {
        PickupCoins(worth);
    }

    void PickupCoins(int amount)
    {
        alison.SetCoin(amount);
    }
    void UseCoins(int amount)
    {
        
        if (alison.GetCoin() < amount)
        {
            //Doesn't have enough coins
        }
        else
        {
            int i = alison.GetCoin() - amount;
            alison.SetCoin(i);
        }
    }
}
