using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwiftSoda : BaseCollectible
{
    public override void ApplyEffect()
    {
        alison.IncreaseSpeed(amount);
        //Puts speed back to normal after specified time
        alison.Invoke("ResetSpeed", duration);
    }

}
