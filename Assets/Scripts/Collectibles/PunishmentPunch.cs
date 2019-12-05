using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunishmentPunch : BaseCollectible
{
    public override void ApplyEffect()
    {
        
        alison.DamageInc(amount);
        alison.Invoke("ResetDamage", duration);
    }


}
