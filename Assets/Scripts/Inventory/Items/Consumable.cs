using UnityEngine;

/* An Item that can be consumed. So far that just means regaining health */

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Consumable")]
public class Consumable : Item
{


    // This is called when pressed in the inventory
    public override void Use()
    {
        if (name == "Health")
        {
            BaseCollectible BC = FindObjectOfType<ReplishmentRemedy>();
            BC.ApplyEffect();
        }
        if (name == "Speed")
        {
            BaseCollectible BC = FindObjectOfType<SwiftSoda>();
            BC.ApplyEffect();
        }
        if (name == "Damage")
        {
            BaseCollectible BC = FindObjectOfType<PunishmentPunch>();
            BC.ApplyEffect();
        }
        Debug.Log(name + " consumed!");

        RemoveFromInventory();  // Remove the item after use
    }

}
