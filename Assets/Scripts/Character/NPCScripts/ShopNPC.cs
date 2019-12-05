using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopNPC : NPCController
{
    public ShopUIManager SUIM;
    Inventory inventory;
    public Item ReplenishRemedy;
    public Item PunishmentPunch;
    public Item SwiftSoda;
    Alison alison;

    void Awake()
    {
        //SUIM = FindObjectOfType<ShopUIManager>();
        inventory = FindObjectOfType<Inventory>();
        alison = FindObjectOfType<Alison>();
   
    }


    public override void Interact()
    {

        //interaction with person
    }

    public void PunishmentPunchGive()
    {
        if (alison.GetCoin() >= PunishmentPunch.ItemCost)
        {
            if (!inventory.IsFull())
            {
                inventory.Add(PunishmentPunch);
                //doesn't work
                if (SUIM)
                    SUIM.buying();
                alison.SetCoin(-PunishmentPunch.ItemCost);
            }
            else
            {
                if (SUIM)
                    SUIM.NPCBoxOne.text = "Your inventory is full";
            }
        }
        else
        {
            if (SUIM)
                SUIM.NoFunds();
        }
    }

    public void ReplenishRemedyGive()
    {
        if (alison.GetCoin() >= ReplenishRemedy.ItemCost)
        {
            if (!inventory.IsFull())
            {
                inventory.Add(ReplenishRemedy);
                //doesn't work
                if (SUIM)
                    SUIM.buying();
                alison.SetCoin(-ReplenishRemedy.ItemCost);
            }
            else
            {
                if (SUIM)
                    SUIM.NPCBoxOne.text = "Your inventory is full";
            }
        }
        else
        {
            if (SUIM)
                SUIM.NoFunds();
        }
    }

    public void SwiftSodaGive()
    {
        if (alison.GetCoin() >= SwiftSoda.ItemCost)
        {
            if (!inventory.IsFull())
            {
                inventory.Add(SwiftSoda);
                //doesn't work
                if (SUIM)
                    SUIM.buying();
                alison.SetCoin(-SwiftSoda.ItemCost);
            }
            else
            {
                if (SUIM)
                    SUIM.NPCBoxOne.text = "Your inventory is full";
            }
        }
        else
        {
            if (SUIM)
                SUIM.NoFunds();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           ShopGiverMenuOff();
        }
    }
}
