using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : BaseEnemy
{
   

    private void Awake()
    {
        ID = "Boss Enemy";
        Experience = 500;
        Coins = 1000;
    }
    public override void Attack()
    {
        enemyAnim.SetLayerWeight(1, 0);
    }



}
