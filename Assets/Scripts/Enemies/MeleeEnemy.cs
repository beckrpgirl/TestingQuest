using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : BaseEnemy
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
        enemyAnim.SetLayerWeight(3, 1);
        enemyAnim.SetFloat("MeleeAttack", 0.6f);
        enemyAnim.SetFloat("Move", 0f);
        if ((player.transform.position - transform.position).magnitude <= attackRange)
        {
            enemyMovement.GetNavMeshAgent().SetDestination(player.transform.position);
        }
    }

}
