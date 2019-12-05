using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : BaseWeapon
{

    public override void Attack()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Health>() && other.gameObject.transform.root.tag != gameObject.transform.root.tag)
        {
            other.GetComponent<Health>().TakeDamage(damageValue);
        }
    }

}
