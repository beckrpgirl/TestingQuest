using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : Health
{

    public RectTransform healthBar;


    private void Update()
    {
        healthBar.sizeDelta = new Vector2(GetCurrentHealth(), healthBar.sizeDelta.y);
    }

}
