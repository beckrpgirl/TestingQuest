using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : BaseWeapon
{
    public GameObject bullet;
    public Transform firingPoint;
    GameManager gm;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }


    public override void Attack()
    {
        bullet = BulletPool.sharedInstance.GetObjectPool("Arrow");
        if (bullet)
        {
            bullet.transform.position = firingPoint.transform.position;
            bullet.transform.rotation = firingPoint.transform.rotation;
            bullet.SetActive(true);
        }
    }

}
