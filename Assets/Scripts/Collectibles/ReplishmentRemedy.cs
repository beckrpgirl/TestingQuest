using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplishmentRemedy : BaseCollectible
{
    public override void ApplyEffect()
    {
        alison.healthBar.Heal(amount);
        Debug.Log("You gained health!");
    }

}
