﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryUI;  // The entire UI
    public Transform itemsParent;   // The parent object of all the items

    Inventory inventory;    // Our current inventory

    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
        inventory.onItemChangedCallback += UpdateUI;
    }

    // Check to see if we should open/close the inventory
    void Update()
    {
        //if (Input.GetButtonDown("Inventory"))
        //{
        //    inventoryUI.SetActive(!inventoryUI.activeSelf);
        //    UpdateUI();
        //}
    }

    // Update the inventory UI by:
    //		- Adding items
    //		- Clearing empty slots
    // This is called using a delegate on the Inventory.
    public void UpdateUI()
    {
        InventorySlots[] slots = GetComponentsInChildren<InventorySlots>();

        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}

