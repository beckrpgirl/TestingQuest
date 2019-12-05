using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy : BaseEnemy
{

    private void Awake()
    {
        ID = "Enemy";
        Experience = 10;
        Coins = 25;
    }

    public override void Attack()
    {
        enemyAnim.SetLayerWeight(1, 0);
        enemyAnim.SetLayerWeight(2, 1);
        enemyAnim.SetFloat("Attack", 0.6f);
        enemyAnim.SetFloat("Move", 0f);
        if (weapon.GetComponent<RangedWeapon>())
        {
            weapon.GetComponent<RangedWeapon>().Attack();
        }
    }
}
